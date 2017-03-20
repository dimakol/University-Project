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
    public partial class F_Lecturer : Form
    {
        Database db = Database.Instance();
        private Lecturer user;
        private Form frm;


        public F_Lecturer()
        {
            InitializeComponent();
            user = (Lecturer)db.USER;
            show_info();
            frm = new Form();
        }

        public void show_info()
        {
            label1.Text = "Welcome, " + user.SDEGREE() + user.FIRSTNAME + " " + user.LASTNAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Info();
            frm.Show();
            show_info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Reception_Hours();
            frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void btnCourseGrades_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Grade_Students();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Change_Password();
            frm.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Add_Courses();
            frm.Show();
        }

        private void F_Lecturer_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Lecturer_MouseMove(object sender, MouseEventArgs e)
        {
            show_info();
        }
        //Mouse hover
        private void btnCourses_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnCourses, "Add courses to students per semester according to what he has left every year");
        }

        private void btnCourseGrades_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnCourseGrades, "Grade assignments");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Edit Reception hours");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "Edit(first name,last name,email,phone number)");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button4, "Change Password");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button3, "Back to login form");
        }
    }
}
