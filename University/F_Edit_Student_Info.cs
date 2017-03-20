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
    public partial class F_Edit_Student_Info : Form
    {
        Database db = Database.Instance();
        private Employee emp;
        private DataTable dt;
        private String Fields = "username,password,id,firstname,lastname,email,phone,dept"; 
        private String Conditions = "dept = ";

        public F_Edit_Student_Info()
        {
            InitializeComponent();
        }
        public F_Edit_Student_Info(Employee _emp)
        {
            InitializeComponent();
            emp = _emp;
            dt = new DataTable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Edit_Student_Info_Load(object sender, EventArgs e)
        {
            Conditions += (int)emp.DEPT + "and type = 0";
            dt = db.FetchTable(db.TPERSON, Fields, Conditions).Tables[db.TPERSON];
            gvTable.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.gvTable.BindingContext[dt].EndCurrentEdit();
            try
            {
                dt = db.UpdateTable(db.TPERSON, Fields, Conditions, dt);
                MessageBox.Show("Update completed succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (id_box.Text != "" && db.checkExistance(db.TSTUDENT, "ID = " + id_box.Text))
            {
                dt = db.FetchTable(db.TPERSON, Fields, "id = " + id_box.Text).Tables[db.TPERSON];
                gvTable.DataSource = dt;
            }
            else
            {
                MessageBox.Show("The ID wasn't found");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }
    }
}
