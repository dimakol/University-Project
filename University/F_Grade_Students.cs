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
    public partial class F_Grade_Students : Form
    {
        Database db = Database.Instance();
        Email em = Email.Instance();

        private DataTable dt;
        private Lecturer user;
        private String cnum;


        public F_Grade_Students()
        {
            InitializeComponent();
            user = (Lecturer)db.USER;
            cnum = "";
            foreach(Course value in user.COURSES)
            {
                comboBox1.Items.Add(value.CNAME);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Condition = "courses LIKE '%";
            foreach(Course value in user.COURSES)
            {
                if (value.CNAME == comboBox1.SelectedItem.ToString())
                {
                    cnum = value.CNUM;
                }
            }
            Condition += cnum + "%'";
            dt = db.FetchTable(db.TSTUDENT, "id", Condition).Tables[db.TSTUDENT];
            dt.Columns.Add(new DataColumn("Grade", typeof(int)));
            dgvCourses.DataSource = dt;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> list = new List<String>(), Adresses = new List<String>();
            String id = "";
            String grade = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i].ItemArray[0].ToString();
                grade = dt.Rows[i].ItemArray[1].ToString();
                if ((grade != "") && Convert.ToInt32(grade) >= 0 && Convert.ToInt32(grade) <= 100)
                {
                    db.updateGrade(id, cnum, grade);
                    if (checkBox1.CheckState == CheckState.Checked)
                    {
                        list = db.FetchList(db.TPERSON, "email", "id = " + dt.Rows[i].ItemArray[0]);
                    }
                }
                else if (grade == "") { }
                else MessageBox.Show("Bad input!", "Error");
            }

            if (checkBox1.CheckState == CheckState.Checked)
                em.AnnounceGrade(list, db.getCourse(cnum).CNAME, grade);


            if (!db.CheckCourse(cnum))
            {
                String code = "";
                for (int i = 0; i < user.COURSES.Count; i++)
                {
                    if (user.COURSES[i].CNUM == cnum)
                    {
                        user.COURSES.Remove(user.COURSES[i]);
                        i--;
                    }
                }
                code = user.encrypt_courses();
                db.SimpleUpdate(db.TEMPLOYEE, "courses = '" + code + "'", "id = " + user.ID);
            }

            this.Close();
        }
    }
}
