using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University
{
    public partial class F_Login : Form
    {
        Database db = Database.Instance();
        private Form frm;

        public F_Login()
        {
            InitializeComponent();
            frm = new Form();
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            Form next_menu = null;

            switch (db.Login(user_box.Text, pass_box.Text))
            {
                case 0: //student
                    next_menu = new F_Student();
                    Student stud = (Student)db.USER;
                    if (!stud.STATE)
                    {
                        MessageBox.Show("Account suspended!", "Error");
                        return;
                    }
                    break;

                case 1: //secretary
                    next_menu = new F_Secretary();
                    break;

                case 2: //tutor
                    next_menu = new F_Tutor(); 
                    break;

                case 3: //lecturer
                    next_menu = new F_Lecturer();  
                    break;

                case 4: //hoad
                    next_menu = new F_Head_Department(); 
                    break;

                case -1:    //bad info
                    MessageBox.Show("Wrong username or password!", "Error");
                    return;

                case -2:    //ex was thrown
                    //MessageBox.Show("Database Error!", "Error");
                    return;
            }

            if (next_menu != null)
            {
                this.Hide();
                next_menu.ShowDialog();
            }
            else MessageBox.Show("That menu is not ready yet!", "Under constraction");
            user_box.Clear();
            pass_box.Clear();
            db.USER = null;
            this.Show();
            user_box.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm = new F_Register();
            frm.Show();
            Point pt = this.Location;
            pt.Offset(8, 30);
            frm.Location = pt;         
            frm.TopMost = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm = new F_Password_Recovery();
            frm.Show();
            Point pt = this.Location;
            pt.Offset(8, 30);
            frm.Location = pt;
            frm.TopMost = true;
        }

        private void F_Login_LocationChanged(object sender, EventArgs e)
        {
            if (frm.Visible == true)
            {
                Point pt = this.Location;
                pt.Offset(8, 30);
                frm.Location = pt;  
            }
        }


        //DO NOT TOUCH BELOW
        private void pass_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void f_login_Load(object sender, EventArgs e)
        {

        }
        private void f_login_Load_1(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_LocationChanged(object sender, EventArgs e)
        {

        }

    }
}
