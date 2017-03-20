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
    public partial class F_Password_Recovery : Form
    {
        Database db = Database.Instance();
        Email em = Email.Instance();


        public F_Password_Recovery()
        {
            InitializeComponent();
        }

        public F_Password_Recovery(Point _loc)
        {
            InitializeComponent();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if ((id_box.Text == "") || (mail_box.Text == ""))
                MessageBox.Show("Please enter text in empty field!", "Error");
            else
            {
                if (!db.checkExistance(db.TPERSON, "id = " + id_box.Text + " and email = '" + mail_box.Text + "'"))
                {
                    MessageBox.Show("ID\\Email mismatch!", "Error");
                    return;
                }
                em.PasswordRec(id_box.Text);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }




        private void F_Password_Recovery_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
