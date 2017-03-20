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
    public partial class F_Edit_Reception_Hours : Form
    {
        Database db = Database.Instance();
        private Employee user;


        public F_Edit_Reception_Hours()
        {
            InitializeComponent();
            user = (Employee)db.USER;
        }

        private void frmEditRcptHrs_Load(object sender, EventArgs e)
        {
            int day = 0;
            List<String> itemList;

            itemList = db.FetchList(db.TRECEPTION, "*", "id = " + user.ID);
            day = Convert.ToInt32(itemList[1]);

            if (day == 1)
            {
                radioButton1.Checked = true;
            }
            else if (day == 2)
            {
                radioButton2.Checked = true;
            }
            else if (day == 3)
            {
                radioButton3.Checked = true;
            }
            else if (day == 4)
            {
                radioButton4.Checked = true;
            }
            else if (day == 5)
            {
                radioButton5.Checked = true;
            }
            else if (day == 6)
            {
                radioButton6.Checked = true;
            }

            dtpickerStartTime.Format = DateTimePickerFormat.Time;
            dtpickerStartTime.ShowUpDown = true;
            if (itemList[2] != "") dtpickerStartTime.Value = Convert.ToDateTime(itemList[2]);


            dtpickerEndTime.Format = DateTimePickerFormat.Time;
            dtpickerEndTime.ShowUpDown = true;
            if (itemList[3] != "") dtpickerEndTime.Value = Convert.ToDateTime(itemList[3]);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Start time is bigger than end time (invalid)
            if (dtpickerStartTime.Value.Ticks >= dtpickerEndTime.Value.Ticks)
            {
                MessageBox.Show("The time entered is invalid");
                return;
            }

            // Day isn't selected
            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked))
            {
                MessageBox.Show("Please select day/s");
                return;
            }

            String sqlFormattedSDate = dtpickerStartTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String sqlFormattedEDate = dtpickerEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            Day day = 0;

            if (radioButton1.Checked)
            {
                day = Day.Sunday;
            }
            else if (radioButton2.Checked)
            {
                day = Day.Monday;
            }
            else if (radioButton3.Checked)
            {
                day = Day.Tuesday;
            }
            else if (radioButton4.Checked)
            {
                day = Day.Wedensday;
            }
            else if (radioButton5.Checked)
            {
                day = Day.Thursday;
            }
            else if (radioButton6.Checked)
            {
                day = Day.Friday;
            }

            db.SimpleUpdate(db.TRECEPTION, "_day = " + (int)day + ", start_hour = '" + sqlFormattedSDate + "', end_hour = '" + sqlFormattedEDate + "'", "id = " + user.ID);
            MessageBox.Show("The reception hours updated");
        }
    }
}
