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
    public partial class F_Change_Password : Form
    {
        Database db = Database.Instance();
        private Person user;

        public F_Change_Password()
        {
            InitializeComponent();
            user = db.USER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> itemList = new List<String>();
            itemList = db.FetchList(db.TPERSON, "password", "id = " + user.ID);
            if (textBox1.TextLength < 4 || textBox2.TextLength < 4 || textBox3.TextLength < 4)
            {
                MessageBox.Show("One of the passwords is too short!", "Message");
                return;
            }
            if (textBox1.Text != itemList[0])
            {
                MessageBox.Show("Incorrect Old Password!", "Message");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("New Passwords Do Not Match!", "Message");
                return;
            }
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("New Password Cannot be the same as the old one!", "Message");
                return;
            }

            db.SimpleUpdate(db.TPERSON, "password = '" + textBox3.Text + "'", "id = " + user.ID);
            MessageBox.Show("Password changed successfully!", "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
