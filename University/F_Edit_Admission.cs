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
    public partial class F_Edit_Admission : Form
    {
        Database db = Database.Instance();
        private Department dept;

        public F_Edit_Admission()
        {
            InitializeComponent();
            dept = db.USER.DEPT;
        }

        private void F_Edit_Admission_Load(object sender, EventArgs e)
        {
            admission_box.Text = db.FetchList(db.TADMISSION, "requirement", "dept = " + (int)dept)[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SimpleUpdate(db.TADMISSION, "requirement = " + admission_box.Text, "dept = " + (int)dept);
            this.Close();
        }

        private void admission_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
