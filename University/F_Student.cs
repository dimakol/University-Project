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
    public partial class F_Student : Form
    {
        Database db = Database.Instance();
        private Student user;
        private Form frm;

        public F_Student()
        {
            InitializeComponent();
            user = (Student)db.USER;
            frm = new Form();
        }

        private void show_info()    //shows the relevant infromation about user
        {
            name_label.Text = "Welcome, " + user.FIRSTNAME + " " + user.LASTNAME;
            dept_label.Text = "Department of " + user.SDEPT() + " Engeneering";
            year_label.Text = "Year " + user.YEAR + ", Semester " + user.SEMESTER;
            avg_label.Text = "Average: " + user.calc_avg();
            pts_label.Text = "Points: " + user.get_pts(false);
        }

        private void crs_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Student_Courses();
            frm.Show();            
        }
        private void grd_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Student_Grades();
            frm.Show();
        }
        private void inf_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Info();
            frm.Show();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void f_student_Load(object sender, EventArgs e)
        {
            show_info();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Change_Password();
            frm.Show();
        }

        private void lib_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Library();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Add_Courses();
            frm.Show();
        }

        private void btnRecept_Hours_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_View_Reception_Hours();
            frm.Show();
        }

        private void F_Student_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Student_MouseMove(object sender, MouseEventArgs e)
        {
            show_info();
        }
        //mousehover

        private void grd_button_MouseHover(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.grd_button, "This button basically Shows You what\n your grades are in all courses done");
        }

        private void crs_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.crs_button, "Shows you what are the courses taken in that semester");
        }
        //graveyard


        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "Add courses to the specific semester you're in");
        }

        private void btnRecept_Hours_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRecept_Hours, "Check Open hours for Lecturers or practitioner so that you could go if needed.");
        }

        private void lib_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.lib_button, "If you want to take books from library for School work.");
        }

        private void inf_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.inf_button, "Edit First name,Last name,Phone number ,Email");
        }

        private void btnAssignments_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAssignments, "Change Your password");
        }

        private void ex_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.ex_button, "Go back to login Form");
        }
    }
}
