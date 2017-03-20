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
    public partial class F_Head_Department_Degree : Form
    {
        Database db = Database.Instance();
        private HeadDept user;
        private DataTable dt;

        public F_Head_Department_Degree()
        {
            InitializeComponent();
            user = (HeadDept)db.USER;
            dt = new DataTable();
        }

        private void F_Head_Department_Degree_Load(object sender, EventArgs e)
        {
            dt = db.FetchTable(db.TPERSON + ", " + db.TSTUDENT, "firstname, lastname, person.id, average", "dept = " + (int)user.DEPT + " and type = 0 and person.id = student.id").Tables[db.TPERSON + ", " + db.TSTUDENT];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Add("Points", "Points");

            for (int i = 0; i < dataGridView1.Rows.Count; i++ )
            {
                Student stud = db.getStudent("id = " + dataGridView1.Rows[i].Cells[3].Value);
                dataGridView1.Rows[i].Cells[5].Value = stud.get_pts(false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Student stud = db.getStudent("id = " + dataGridView1.Rows[i].Cells[3].Value);
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                if (!string.IsNullOrEmpty(this.textBox1.Text.ToString()))
                {
                    if (stud.get_pts(false) < Convert.ToInt32(textBox1.Text))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                    else dataGridView1.Rows[i].Visible = true;
                }
                currencyManager1.ResumeBinding();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) 
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                    {
                        db.DeleteFromTable(db.TSTUDENT, "id", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        db.DeleteFromTable(db.TPERSON, "id", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        db.AddToTable(db.TGRADUATES, dataGridView1.Rows[i].Cells[3].Value + ",'" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "'," + dataGridView1.Rows[i].Cells[5].Value + "," + dataGridView1.Rows[i].Cells[4].Value);
                    }
                }

                dataGridView1.Columns.Remove("Points");
                dt = db.FetchTable(db.TPERSON + ", " + db.TSTUDENT, "firstname, lastname, person.id, average", "dept = " + (int)user.DEPT + " and type = 0 and person.id = student.id").Tables[db.TPERSON + ", " + db.TSTUDENT];
                dataGridView1.DataSource = dt;
                dataGridView1.Columns.Add("Points", "Points");

                String str = textBox1.Text;
                textBox1.Clear();
                if (str != "") textBox1.Text = str;
            }
        }
    }
}
