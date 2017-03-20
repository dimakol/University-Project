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
    public partial class F_Tutor : Form
    {
        Database db = Database.Instance();
        private Form frm;
        private Tutor user;

        public F_Tutor()
        {
            InitializeComponent();
            frm = new Form();
            user = (Tutor)db.USER;
            show_info();
        }
        
        public void show_info()
        {
            hello_label.Text = "Welcome, " + user.SDEGREE() + user.FIRSTNAME + " " + user.LASTNAME + "\nTutor of " + user.SDEPT() + " Engineering Department.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Info();
            frm.Show();
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

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Change_Password();
            frm.Show();
        }

        private void F_Tutor_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Tutor_MouseMove(object sender, MouseEventArgs e)
        {
            show_info();
        }
        //mousehover
        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "Edit personal info(first name,last name,email,phone)");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Edit free hours for students to be able to come and ask questions");
        }

        private void btn_ChangePass_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_ChangePass, "Change password");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button3, "Go back to login form");
        }

    }
}
