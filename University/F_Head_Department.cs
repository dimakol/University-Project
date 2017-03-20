using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace University
{
    public partial class F_Head_Department : Form
    {
        Database db = Database.Instance();
        private HeadDept user;
        private Form frm;

        public F_Head_Department()
        {
            InitializeComponent();
            user = (HeadDept)db.USER;
            frm = new Form();
        }

        private void Edit_Course_Details_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new frmEdit_Course();
            frm.Show();
        }

        private void Edit_Reception_Hours_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Reception_Hours();
            frm.Show();
        }

        private void Edit_Personal_Details_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Info();
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void Edit_Lecturer_Details_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Person_Info(Job.Lect, user.DEPT);
            frm.Show();
        }

        private void Edit_Practitioner_Details_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Person_Info(Job.Tut, user.DEPT);
            frm.Show();
        }


        private void Freeze_Coursework_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Head_Department_Suspension();
            frm.Show();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Change_Password();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Student_Grades(user);
            frm.Show();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Admission();
            frm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Head_Department_Degree();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Head_Department_Graduates();
            frm.Show();
        }

        private void F_Head_Department_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void show_info()
        {
            label1.Text = "Welcome, " + user.SDEGREE() + user.FIRSTNAME + " " + user.LASTNAME + "\nHead of " + user.SDEPT() + " Engineering Department.";
        }


        private void F_Head_Department_MouseMove(object sender, MouseEventArgs e)
        {
            show_info();
        }

        private void F_Head_Department_Load(object sender, EventArgs e)
        {
            show_info();
        }
       //mousehover
        private void Edit_Reception_Hours_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Edit_Reception_Hours, "Edit Your Reception Hours");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "View Who Graduated from Our university");
        }

        private void btnGrads_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnGrads, "Give Degree To students who are qualified to it :)");
        }

        private void Edit_Personal_Details_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Edit_Personal_Details, "Edit First name,last name,Phone,Email");
        }

        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnChangePass, "Change Your password");
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnLogOut, "Go back to login");
        }

        private void Edit_Course_Details_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Edit_Course_Details, "Edit or Add (Course name,Academic year,Semester,Department,Point, previous Courses)");
        }

        private void Edit_Lecturer_Details_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Edit_Lecturer_Details, "Edit email,phone,first name ,last name");
        }

        private void Edit_Practitioner_Details_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Edit_Practitioner_Details, "View Tutor Salary");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnSearch, "View Students Courses taken,average,points covered");
        }

        private void btnAdmission_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAdmission, "Change the Grade for admission");
        }

        private void Freeze_Coursework_MouseHover(object sender, EventArgs e)
        {
           

        }
    }
}
