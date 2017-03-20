using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class F_Edit_Person_Info : Form
    {
        Database db = Database.Instance();
        private DataTable dt;

        private Employee user;

        public F_Edit_Person_Info()
        {
            InitializeComponent();
            user = (Employee)db.USER;
            dt = new DataTable();
        }

        public F_Edit_Person_Info(Job jb, Department dept)  //head dept
        {
            InitializeComponent();
            if (jb == Job.Lect) user = new Lecturer();
            if (jb == Job.Tut) user = new Tutor();
            user.DEPT = dept;
            dt = new DataTable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Edit_Person_Info_Load(object sender, EventArgs e)
        {
            gvTable.Width = this.Width;
            gvTable.Height = this.Height - 100;
            String Fields1 = "person.firstname, person.lastname, person.id, person.email, employee.salary, employee.degree";
            String Conditions1 = "person.id = employee.id and person.type = " + (int)user.JOB + " and person.dept = " + (int)user.DEPT;

            String Fields2 = "username, firstname, lastname, id, email, phone";
            String Conditions2 = "dept = " + (int)user.DEPT + " AND type = 0";

            if (user.JOB == Job.Lect || user.JOB == Job.Tut)
            {
                dt = db.FetchTable(db.TPERSON + ", " + db.TEMPLOYEE, Fields1, Conditions1).Tables[db.TPERSON + ", " + db.TEMPLOYEE];
            }
            else if(user.JOB == Job.Sec)
            {
                dt = db.FetchTable(db.TPERSON, Fields2, Conditions2).Tables[db.TPERSON];
            }

            gvTable.DataSource = dt;
            gvTable.Columns[0].ReadOnly = true;
            gvTable.Columns[1].ReadOnly = true;
            gvTable.Columns[2].ReadOnly = true;
            gvTable.Columns[3].ReadOnly = true;

            if (user.JOB == Job.Lect || user.JOB == Job.Tut)
            {
                gvTable.Columns[0].HeaderText = "First Name";
                gvTable.Columns[1].HeaderText = "Last Name";
                gvTable.Columns[2].HeaderText = "ID Number";
                gvTable.Columns[3].HeaderText = "Email Address";
                gvTable.Columns[4].Visible = false;
                gvTable.Columns[5].HeaderText = "Degree";
                gvTable.Columns[5].ReadOnly = true;          
            }
            else if (user.JOB == Job.Sec)
            {
                gvTable.Columns[0].HeaderText = "Username";
                gvTable.Columns[1].HeaderText = "First Name";
                gvTable.Columns[2].HeaderText = "Last Name";
                gvTable.Columns[3].HeaderText = "ID Number";
                gvTable.Columns[4].HeaderText = "Email Address";
                gvTable.Columns[5].HeaderText = "Phone Number";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Fields1 = "id, salary, degree";
            String Conditions1 = "type = " + (int)user.JOB;

            String Fields2 = "username, firstname, lastname, id, email, phone";
            String Conditions2 = "dept = " + (int)user.DEPT + "AND type = 0";

            this.gvTable.BindingContext[dt].EndCurrentEdit();
            try
            {
                if (user.JOB == Job.Lect || user.JOB == Job.Tut)
                {
                    dt = db.UpdateTable(db.TEMPLOYEE, Fields1, Conditions1, dt);
                }
                else if (user.JOB == Job.Sec)
                {
                    dt = db.UpdateTable(db.TPERSON, Fields2, Conditions2, dt);
                }
                else return;

                MessageBox.Show("Updated Succesfully!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");              
            }
        }

        // Editing gridview cell
        private void gvTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (user.JOB != Job.Sec)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (gvTable.CurrentCell.ColumnIndex == 4) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }
        }

        // Column Key Press
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
