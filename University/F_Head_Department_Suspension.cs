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
    public partial class F_Head_Department_Suspension : Form
    {
        Database db = Database.Instance();
        private HeadDept user;
        private DataTable dt;
        private Boolean HandleChange = true;

        public F_Head_Department_Suspension()
        {
            InitializeComponent();
            button1.Hide();
            user = (HeadDept)db.USER;
        }

        private void F_Head_Department_Suspension_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            dt = db.FetchTable(db.TSTUDENT + "," + db.TPERSON, "student.id, person.firstname, person.lastname", "student.id = person.id AND dept = " + (int)user.DEPT + " AND state = 1").Tables[db.TSTUDENT + "," + db.TPERSON];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + ", " + dt.Rows[i].ItemArray[0].ToString());
            }
            dt = db.FetchTable(db.TSTUDENT + "," + db.TPERSON, "student.id, person.firstname, person.lastname", "student.id = person.id AND dept = " + (int)user.DEPT + " AND state = 0").Tables[db.TSTUDENT + "," + db.TPERSON];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i].ItemArray[1].ToString() + " " + dt.Rows[i].ItemArray[2].ToString() + ", " + dt.Rows[i].ItemArray[0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HandleChange)
            {
                HandleChange = false;
                comboBox2.SelectedIndex = -1;
                button1.Text = "Suspend";
                button1.Show();
                HandleChange = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HandleChange)
            {
                HandleChange = false;
                comboBox1.SelectedIndex = -1;
                button1.Text = "Activate";
                button1.Show();
                HandleChange = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] info = new String[2];
            if (button1.Text == "Suspend") info = comboBox1.Text.Split(',');
            if (button1.Text == "Activate") info = comboBox2.Text.Split(',');
            db.freezeStudent(info[1]);
            if (button1.Text == "Suspend") MessageBox.Show("Suspended Successfully!", "Message");
            if (button1.Text == "Activate") MessageBox.Show("Activated Successfully!", "Message");
            F_Head_Department_Suspension_Load(new object(), new EventArgs());
        }



    }
}
