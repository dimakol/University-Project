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
    public partial class F_Cancel_Mail : Form
    {
        Database db = Database.Instance();
        Email em = Email.Instance();

        private DataTable dt;
        private Person user;

        public F_Cancel_Mail()
        {
            InitializeComponent();
            user = db.USER;
        }

        private void F_Cancel_Mail_Load(object sender, EventArgs e)
        {
            label3.Hide();
            LectBox.Items.Clear();
            dt = db.FetchTable(db.TPERSON, "firstname, lastname, id", "dept = " + (int)user.DEPT + " and (type = 2 or type = 3)").Tables[db.TPERSON];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LectBox.Items.AddRange(new object[] { dt.Rows[i].ItemArray[0].ToString() + " " + dt.Rows[i].ItemArray[1].ToString() });
            }
        }

        private void cbLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Hide();
            CourseBox.Items.Clear();
            Student stud = new Student();
            List<String> courses = db.FetchList(db.TEMPLOYEE, "courses", "id = " + dt.Rows[LectBox.SelectedIndex].ItemArray[2].ToString());
            stud.decrypt_courses(courses[0]);
            for (int i = 0; i < stud.COURSES.Count; i++)
            {
                CourseBox.Items.AddRange(new object[] { stud.COURSES[i].CNAME });
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<String> course = db.FetchList(db.TCOURSE, "Course_Number", "Course_Name = '" + CourseBox.Text + "'");
            List<String> emails = new List<string>();
            dt = db.FetchTable(db.TSTUDENT, "id", "courses LIKE '%" + course[0] + "%'").Tables[db.TSTUDENT];
            for(int i = 0; i <dt.Rows.Count; i++)
            {
                List<String> mail = db.FetchList(db.TPERSON, "email", "id = " + dt.Rows[i].ItemArray[0].ToString());
                if (mail[0] != "") emails.Add(mail[0]);
            }
            em.AnnounceCancel(emails, CourseBox.Text, LectBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "You are about to send a cancelation mail for\nthe next lecture with " + LectBox.Text + "\nin \"" + CourseBox.Text + "\"!";
            label3.Show();
        }

    }
}
