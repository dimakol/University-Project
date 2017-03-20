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
    public partial class F_Secretary : Form
    {
        Database db = Database.Instance();
        private Secretary user;
        private Form frm;

        public F_Secretary()
        {
            InitializeComponent(); 
            user = (Secretary)db.USER;
            show_info();
            frm = new Form();
        }

        public void show_info()
        {
            name_label.Text = "Welcome, " + user.SDEGREE() + user.FIRSTNAME + " " + user.LASTNAME + "\nSecretary of " + user.SDEPT() + " Engineering Department.";
        }

        private void edt_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Person_Info();
            frm.Show();
        }

        private void inf_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Edit_Info();
            frm.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Register();
            frm.Width = 300;
            frm.Height = this.Height - 240;
            frm.Show();            
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            String[] list = comboBox1.Text.Split(' ');
            Student stud = db.getStudent("id = " + list[2]);

            frm.Close();
            frm = new F_Add_Courses(stud);
            frm.Show();
        }

        private void btnChange_Pass_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Change_Password();
            frm.Show();
        }

        private void btnCancelMail_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm = new F_Cancel_Mail();
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddCourse.Show();
        }

        private void F_Secretary_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void F_Secretary_Load(object sender, EventArgs e)
        {
            btnAddCourse.Hide();
            DataTable dt = db.FetchTable(db.TPERSON + ", " + db.TSTUDENT, "firstname, lastname, student.*", "dept = " + (int)user.DEPT + " and type = 0 and person.id = student.id").Tables[db.TPERSON + ", " + db.TSTUDENT];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.AddRange(new object[] { dt.Rows[i].ItemArray[0].ToString() + " " + dt.Rows[i].ItemArray[1].ToString() + ", " + dt.Rows[i].ItemArray[2].ToString() });
            }
        }

        private void F_Secretary_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Close();
        }

        private void F_Secretary_MouseMove(object sender, MouseEventArgs e)
        {
            show_info();
        }
        //mousehover

        private void btnAddCourse_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAddCourse, "Add courses to students per semester according to what he has left every year");
        }

        private void btnAddStudent_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAddStudent, "Add Student by entering the fields into the form");
        }

        private void btnEditStudent_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnEditStudent, "Edit email and phone number");
        }

        private void btnSendMail_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnSendMail, "Send cancel lectures depending on department");
        }

        private void btnMyInfo_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnMyInfo, "Edit first name,last name,email,phone number");
        }

        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnChangePass, "Change Password");
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnLogout, "Back to login");
        }
    }
}
