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
    public partial class F_Register : Form
    {
        Database db = Database.Instance();
        private Department stud_dept = Department.UND;
        private Secretary user;

        //Methods-------------------------------------------------------------------------------------------//
        public F_Register()  
        {
            InitializeComponent();
            user = (Secretary)db.USER;

            if (user != null)
            {
                Point pt = new Point();

                type_box.Hide();
                label6.Hide();

                dept_box.Hide();
                label10.Hide();

                type_box.Items.Add("Student");
                type_box.SelectedIndex = 0;
                dept_box.Items.Add(user.SDEPT());
                dept_box.SelectedIndex = 0;
                grade_label.Show();
                grade_box.Show();

                WindowState = FormWindowState.Normal;
                StartPosition = FormStartPosition.CenterScreen;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

                // password label
                pt = label2.Location;
                pt.Offset(0, 20);
                label2.Location = pt;
                // password box
                pt = pass_box.Location;
                pt.Offset(0, 20);
                pass_box.Location = pt;
                // id label
                pt = label3.Location;
                pt.Offset(0, 40);
                label3.Location = pt;
                // id box
                pt = id_box.Location;
                pt.Offset(0, 40);
                id_box.Location = pt;
                // firstname label
                pt = label4.Location;
                pt.Offset(0, 60);
                label4.Location = pt;
                // firstname box
                pt = fname_box.Location;
                pt.Offset(0, 60);
                fname_box.Location = pt;
                // lastname label
                pt = label5.Location;
                pt.Offset(0, 80);
                label5.Location = pt;
                // lastname box
                pt = lname_box.Location;
                pt.Offset(0, 80);
                lname_box.Location = pt;
                // email label
                pt = label8.Location;
                pt.Offset(0, 100);
                label8.Location = pt;
                // email box
                pt = mail_box.Location;
                pt.Offset(0, 100);
                mail_box.Location = pt;
                //phone label
                pt = label8.Location;
                pt.Offset(0, 46);
                label9.Location = pt;
                //phone box
                pt = mail_box.Location;
                pt.Offset(0, 46);
                phon_box.Location = pt;
                phon_box.Size = mail_box.Size;
                //m radio 
                pt = phon_box.Location;
                pt.Offset(6, 46);
                m_radio.Location = pt;
                //f radio 
                pt = m_radio.Location;
                pt.Offset(62, 0);
                f_radio.Location = pt;
                //gender label
                pt = label9.Location;
                pt.Offset(0, 46);
                label7.Location = pt;
                //grade label
                pt = label7.Location;
                pt.Offset(-5, 40);
                grade_label.Location = pt;
                //grade box
                pt = phon_box.Location;
                pt.Offset(1, 86);
                grade_box.Location = pt;
                grade_box.Size = mail_box.Size;
                //ok button
                pt = grade_label.Location;
                pt.Offset(-10, 40);
                ok_button.Location = pt;
                //exit button
                pt = ok_button.Location;
                pt.Offset(120, 0);
                ex_button.Location = pt;

                stud_dept = user.DEPT;
            }

            else
            {
                type_box.Show();
                label6.Show();
                dept_box.Show();
                label10.Show();

                grade_label.Hide();
                grade_box.Hide();

                type_box.Items.AddRange(new object[] {
                "Tutor",
                "Lecturer",
                "Secretary",
                "Head of a Department"});
                dept_box.Items.AddRange(new object[] {
                "Software",
                "Electronic",
                "Civil",
                "Chemistry",
                "Industrial-Management",
                "Machines"});
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            int gen;
            Job type = Job.UND;
            Department dept = Department.UND;

            //Possible errors from not completing the registration form correctly:
            if ((user_box.TextLength < 4) || (pass_box.TextLength < 4) || (id_box.TextLength < 4))    //if credentials too short
            {
                MessageBox.Show("Username, password or ID too short!\nMust be at least 4 characters!", "Error");
                return;
            }
            if (fname_box.Text == "" || lname_box.Text == "")
            {
                MessageBox.Show("Must type in full name!", "Error");
                return;
            }
            if(grade_box.Visible == true && grade_box.Text == "")
            {
                MessageBox.Show("Must type in grade!", "Error");
                return;
            }
            if (m_radio.Checked == false && f_radio.Checked == false)   //if not selected gender
            {
                MessageBox.Show("Must choose a gender!", "Error");
                return;
            }
            else if (m_radio.Checked) { gen = 1; }    //if selected male
            else { gen = 2; }                        //if selected female
            if (type_box.GetItemText(type_box.SelectedItem) == "")     //if not selected type
            {
                MessageBox.Show("Must choose a type!", "Error");
                return;
            }
            else switch (dept_box.Text)
                {
                    case "Software":
                        dept = Department.SE;
                        break;

                    case "Electronic":
                        dept = Department.EE;
                        break;

                    case "Civil":
                        dept = Department.CE;
                        break;

                    case "Chemistry":
                        dept = Department.CHE;
                        break;

                    case "Industrial-Management":
                        dept = Department.IME;
                        break;

                    case "Machines":
                        dept = Department.ME;
                        break;
                }
            if (dept_box.GetItemText(dept_box.SelectedItem) == "")    //if didn't choose department
            {
                MessageBox.Show("Must choose a department!", "Error");
                return;
            }
            else switch (type_box.Text)
                {
                    case "Secretary":
                        type = Job.Sec;
                        break;

                    case "Tutor":
                        type = Job.Tut;
                        break;

                    case "Lecturer":
                        type = Job.Lect;
                        break;

                    case "Head of a Department":
                        type = Job.HoaD;
                        break;
                }
            //-------------------------------------------------------------------------------------------------------//
            //if everything with form is ok:
            if(stud_dept != Department.UND) //if student
                if (Convert.ToInt32(db.FetchList("Admission", "requirement", "dept = " + (int)stud_dept)[0]) > Convert.ToInt32(grade_box.Text))
                {
                    MessageBox.Show("Average too low!", "Error");
                    return;
                }

            if (db.register(user_box.Text, pass_box.Text, id_box.Text, fname_box.Text, lname_box.Text, mail_box.Text, phon_box.Text, gen, (int)dept, (int)type))
            {
                MessageBox.Show("Registrated successfully!", "Success!");
                this.Close();
            }
            return;
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_register_Load(object sender, EventArgs e)
        {
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phon_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grade_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
