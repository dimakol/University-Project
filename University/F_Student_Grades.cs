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
    public partial class F_Student_Grades : Form
    {
        Database db = Database.Instance();
        DataTable dt;
        private Student user;

        public F_Student_Grades()
        {
            InitializeComponent();
            user = (Student)db.USER;
            label1.Hide();
            comboBox1.Hide();
            label2.Hide();
        }

        public F_Student_Grades(HeadDept _user)
        {
            InitializeComponent();
            user = new Student();
            dt = new DataTable();
            user.DEPT = _user.DEPT;
            AddStudents();
            label2.Hide();
        }


        private void F_Student_Grades_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < user.GRADES.Count; i++)
            {
                ListViewItem Lvi = new ListViewItem(user.GRADES[i].CNAME);
                Lvi.SubItems.Add(user.GRADES[i].YEAR.ToString());
                Lvi.SubItems.Add(user.GRADES[i].SEMESTER.ToString());
                Lvi.SubItems.Add(user.GRADES[i].GRADE.ToString());
                Lvi.SubItems.Add(user.GRADES[i].POINTS.ToString());
                listView1.Items.Add(Lvi);
            }
            label2.Text = user.FIRSTNAME + " " + user.LASTNAME + "\nAverage: " + user.AVERAGE + "\nPoints: " + user.get_pts(false).ToString();
        }

        private void AddStudents()
        {
            dt = db.FetchTable(db.TSTUDENT + "," + db.TPERSON, "student.id", "student.id = person.id AND dept = " + (int)user.DEPT).Tables[db.TSTUDENT + "," + db.TPERSON];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            String condition = "ID = " + comboBox1.Text;
            if (comboBox1.Text != "" && db.checkExistance(db.TSTUDENT, condition))
            {
                user = db.getStudent(condition);
                label2.Show();
                F_Student_Grades_Load(new object(), new EventArgs());
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
