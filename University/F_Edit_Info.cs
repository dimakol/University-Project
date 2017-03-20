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
    public partial class F_Edit_Info : Form
    {
        Database db = Database.Instance();
        private Person user;

        public F_Edit_Info()
        {
            InitializeComponent();
            user = db.USER;
        }

        private void F_Edit_Info_Load(object sender, EventArgs e)
        {
            fname_box.Text = user.FIRSTNAME;
            lname_box.Text = user.LASTNAME;
            mail_box.Text = user.MAIL;
            phon_box.Text = user.PHONE;
        }

        private void ok_button_Click(object sender, EventArgs e)    //since we only update person info, no need to touch student table
        {
            String Fields = "firstname = '" + fname_box.Text + "', lastname = '" + lname_box.Text +
                                 "', phone = '" + phon_box.Text + "', email = '" + mail_box.Text + "'";

            if (fname_box.Text == "" || lname_box.Text == "")
            {
                MessageBox.Show("Must type in full name!", "Error");
                return;
            }
            if(db.checkExistance(db.TPERSON, "email = '" + mail_box.Text + "'") && (mail_box.Text != user.MAIL))   //if user changed mail and its taken
            {
                MessageBox.Show("E-Mail already taken!\nPlease choose a different address.", "Error");
                return;
            }

            db.SimpleUpdate(db.TPERSON, Fields, "id = " + user.ID);
            user.FIRSTNAME = fname_box.Text;
            user.LASTNAME = lname_box.Text;
            user.PHONE = phon_box.Text;
            user.MAIL = mail_box.Text;
            db.USER = user;
            
            MessageBox.Show("Updated successfully!", "Message");
            this.Close();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phon_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if key is not digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
