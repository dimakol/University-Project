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
    public partial class frmEdit_Course : Form
    {
        Database db = Database.Instance();
        private HeadDept user;
        private DataTable dt;
        private String Conditions = "Department = ";


        public frmEdit_Course()
        {
            InitializeComponent();
            user = (HeadDept)db.USER;
            dt = new DataTable();
        }

        private void Head_Department_Edit_Course_Details_Load(object sender, EventArgs e)
        {
            Conditions += (int)user.DEPT + " or Department = " + 0;
            dt = db.FetchTable(db.TCOURSE, "*", Conditions).Tables[db.TCOURSE];
            dgvCourses.DataSource = dt;
            dgvCourses.Columns[1].Width = 250;
            dgvCourses.Columns[0].ReadOnly = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            dgvCourses.BindingContext[dt].EndCurrentEdit();
            try
            {
                dt = db.UpdateTable(db.TCOURSE, "*", Conditions, dt);
                MessageBox.Show("Update completed succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
