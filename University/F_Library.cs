using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class F_Library : Form
    {
        Database db = Database.Instance();

        private Student user;
        private DataTable dt;

        public F_Library()
        {
            InitializeComponent();
            dt = new DataTable();
            user = (Student)db.USER;
        }

        private void F_Library_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String fields = "Book_Number, Book_Name, Author, Book_Count";
            if (radioButton1.Checked == true)
            {
                dt = db.FetchTable(db.TLIBRARY, fields, "Department >= 0").Tables[db.TLIBRARY];
            }
            else
            {
                dt = db.FetchTable(db.TLIBRARY, fields, "Department = 0 OR Department = " + (int)user.DEPT).Tables[db.TLIBRARY];
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> bnums = new List<String>();
            Boolean copies_flag = false, ownership_flag = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    if (Convert.ToInt32(dt.Rows[i].ItemArray[3].ToString()) > 0)
                    {
                        foreach (Book value in user.BOOKS)
                        {
                            if (value.BNUM == Convert.ToInt32(dt.Rows[i].ItemArray[0]))
                            {
                                ownership_flag = true;
                            }
                        }
                        bnums.Add(dt.Rows[i].ItemArray[0].ToString());
                    }
                    else copies_flag = true;
                }
            }

            if (copies_flag == true)
            {
                MessageBox.Show("One or more of the selected books is not in stock!", "Message");
                return;
            }

            if (ownership_flag == true)
            {
                MessageBox.Show("You already have one or more of the selected books!", "Message");
                return;
            }


            int num;

            dataGridView1.Columns[4].ReadOnly = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (bnums.Contains(dt.Rows[i].ItemArray[0].ToString()))
                {
                    num = Convert.ToInt32(dt.Rows[i].ItemArray[3].ToString()) - 1;
                    dataGridView1.Rows[i].Cells[4].Value = num;
                    dt.Rows[i].ItemArray[3] = num;
                }
            }
            dataGridView1.Columns[4].ReadOnly = true;
            dt = db.UpdateTable(db.TLIBRARY, "Book_Number, Book_Count", "Department = 0 OR Department = " + (int)user.DEPT, dt);

            foreach (Book value in user.BOOKS)
            {
                bnums.Add(value.BNUM.ToString());
            }

            String book_code = user.encrypt_books(bnums);
            db.SimpleUpdate(db.TSTUDENT, "Books = '" + book_code + "'", "id = " + user.ID);
            user.decrypt_books(book_code);

            MessageBox.Show("You have successfully taken all the selected books!", "Message");

            foreach (DataGridViewRow value in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)value.Cells[0];
                chk.Value = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                radioButton1.Show();
                radioButton2.Show();
                button1.Show();
                button2.Hide();
                radioButton1.Checked = false;
                radioButton1.Checked = true;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                radioButton1.Hide();
                radioButton2.Hide();
                button1.Hide();
                button2.Show();
                dt = new DataTable();
                dt.Columns.Add("Book Name", typeof(String));
                dt.Columns.Add("Author", typeof(String));
                dt.Columns.Add("Bnum", typeof(Int32));

                foreach (Book value in user.BOOKS)
                {
                    dt.Rows.Add(dt.NewRow());
                    dt.Rows[dt.Rows.Count - 1].SetField(0, value.NAME);
                    dt.Rows[dt.Rows.Count - 1].SetField(1, value.AUTHOR);
                    dt.Rows[dt.Rows.Count - 1].SetField(2, value.BNUM);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> bnums = new List<String>();
            List<Book> Books = new List<Book>(), newBooks = new List<Book>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    Books.Add(db.getBook(dt.Rows[i].ItemArray[2].ToString()));
                }
            }


            for (int i = 0; i < user.BOOKS.Count; i++)
            {
                Boolean eflag = false;
                for (int j = 0; j < Books.Count; j++)
                {
                    if (Books[j].isEqual(user.BOOKS[i]))
                    {
                        eflag = true;                  
                    }
                }
                if (eflag != true) newBooks.Add(user.BOOKS[i]);
            }

            foreach (Book value in newBooks)
            {
                bnums.Add(value.BNUM.ToString());
            }
            foreach (Book value in Books)
            {
                db.SimpleUpdate(db.TLIBRARY, "Book_Count = Book_Count + 1", "Book_Number = " + value.BNUM);
            }

            String book_code = user.encrypt_books(bnums);

            db.SimpleUpdate(db.TSTUDENT, "Books = '" + book_code + "'", "id = " + user.ID);

            MessageBox.Show("You have successfully returned all the selected books!", "Message");
            user.BOOKS = newBooks;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 1;
        }
    }
}
