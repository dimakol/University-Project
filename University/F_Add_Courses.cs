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
    public partial class F_Add_Courses : Form
    {
        Database db = Database.Instance();
        private DataTable dt;
        private Student stud = null;
        private Lecturer lect = null;


        public F_Add_Courses()
        {
            InitializeComponent();
            dt = new DataTable();
            if (db.USER.GetType() == typeof(Lecturer)) lect = (Lecturer)db.USER;
            if (db.USER.GetType() == typeof(Student)) stud = (Student)db.USER;
        }

        public F_Add_Courses(Student _user)
        {
            InitializeComponent();
            dt = new DataTable();
            stud = _user;
        }

        private void F_Add_Courses_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width;
            dataGridView1.Height = this.Height - 100;

            if(lect != null)
            {
                String fields = "Course_Number, Course_Name, Accademic_Year, Semester, Points";
                dt = db.FetchTable(db.TCOURSE, fields, "Department = 0 OR Department = " + (int)lect.DEPT).Tables[db.TCOURSE];
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;

                dataGridView1.Columns[1].Visible = false;

                DataTable ctable = db.FetchTable(db.TEMPLOYEE, "courses", "type = 3").Tables[db.TEMPLOYEE];
                String long_code = "";
                for (int i = 0; i < ctable.Rows.Count; i++)
                {
                    long_code += ctable.Rows[i].ItemArray[0].ToString();
                }
                String[] carray = long_code.Split('#');

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        foreach (String value in carray)
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString() == value)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                                i--;
                                break;
                            }
                        }
                        currencyManager1.ResumeBinding();
                    }
            }

            if (stud != null)
            {
                String fields = "Course_Number, Course_Name, Accademic_Year, Semester, Points, Pre";

                dt = db.FetchTable(db.TCOURSE, fields, "Department = 0 OR Department = " + (int)stud.DEPT).Tables[db.TCOURSE];
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;

                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[6].Visible = false;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Student pre = new Student();
                    Boolean flag2 = false;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    pre.decrypt_courses(dataGridView1.Rows[i].Cells[6].Value.ToString());
                    if (((int)stud.YEAR < Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)) || ((int)stud.SEMESTER < Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value)))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        i--;
                    }
                    else
                    {
                        foreach (Course value in stud.COURSES)
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString() == value.CNUM)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                                i--;
                                flag2 = true;
                                break;
                            }
                        }

                        if(flag2 != true)
                        foreach (Course value in stud.GRADES)
                        {
                            if ((dataGridView1.Rows[i].Cells[1].Value.ToString() == value.CNUM) && (value.GRADE > 55))
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                                i--;
                                flag2 = true;
                                break;
                            }
                        }

                        if (flag2 != true)
                        foreach (Course pvalue in pre.COURSES)
                        {
                            Boolean flag = false;
                            foreach (Course value in stud.GRADES)
                            {
                                if ((value.CNUM == pvalue.CNUM) && (value.GRADE >= 56))
                                {
                                    flag = true;
                                    break;
                                }
                            }

                            if (flag == false)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                                i--;
                                break;
                            }
                        }
                    }
                    currencyManager1.ResumeBinding();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String courses = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    courses += dataGridView1.Rows[i].Cells[1].Value.ToString() + "#";
                }
            }
            
            if (lect != null)
            {
                if (lect.COURSES.Count == 0) db.SimpleUpdate(db.TEMPLOYEE, "Courses = '" + courses + "'", "id = " + lect.ID);
                else db.SimpleUpdate(db.TEMPLOYEE, "Courses = Courses + '" + courses + "'", "id = " + lect.ID);
                lect.decrypt_courses(courses);
                MessageBox.Show("The courses that selected are added");
                F_Add_Courses_Load(new object(), new EventArgs());
            }

            if (stud != null)
            {
                if (stud.COURSES.Count == 0) db.SimpleUpdate(db.TSTUDENT, "Courses = '" + courses + "'", "id = " + stud.ID);
                else db.SimpleUpdate(db.TSTUDENT, "Courses = Courses + '" + courses + "'", "id = " + stud.ID); 
                stud.decrypt_courses(courses);
                for (int i = 0; i < stud.COURSES.Count; i++)
                {
                    foreach (Course value in stud.GRADES)
                    {
                        if (value.CNUM == stud.COURSES[i].CNUM)
                        {
                            stud.GRADES.Remove(value);
                            break;
                        }
                    }
                }

                String gradecode = "";
                for (int i = 0; i < stud.GRADES.Count; i++)
                {
                    gradecode += stud.GRADES[i].CNUM + '$' + stud.GRADES[i].GRADE + '#';
                }
                db.SimpleUpdate(db.TSTUDENT, "grades = '" + gradecode + "'", "id = " + stud.ID);
                MessageBox.Show("The courses that were selected are added");
                F_Add_Courses_Load(new object(), new EventArgs());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
