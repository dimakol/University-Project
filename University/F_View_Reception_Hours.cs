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
    public partial class F_View_Reception_Hours : Form
    {
        Database db = Database.Instance();
        DataTable dt;
        private Student user;

        public F_View_Reception_Hours()
        {
            InitializeComponent();
            user = (Student)db.USER;
        }

        private void F_View_Reception_Hours_Load(object sender, EventArgs e)
        {
            fill_listbox();
        }

        void fill_listbox()
        {
            dt = db.FetchTable(db.TPERSON + ", " + db.TRECEPTION, "firstname, lastname, ReceptionHours.id, _day, start_hour, end_hour", "dept = " + (int)user.DEPT + " and person.id = ReceptionHours.id").Tables[db.TPERSON + ", " + db.TRECEPTION];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox_Employees.Items.AddRange(new object[] { dt.Rows[i].ItemArray[0].ToString() + " " + dt.Rows[i].ItemArray[1].ToString() });
            }
        }

        private void listBox_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            String day = ((Day)Convert.ToInt32(dt.Rows[listBox_Employees.SelectedIndex].ItemArray[3].ToString())).ToString();
            tbDay.Text = day;
            tbStart.Text = Convert.ToDateTime(dt.Rows[listBox_Employees.SelectedIndex].ItemArray[4].ToString()).ToString("HH:mm:ss");
            tbEnd.Text = Convert.ToDateTime(dt.Rows[listBox_Employees.SelectedIndex].ItemArray[5].ToString()).ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
