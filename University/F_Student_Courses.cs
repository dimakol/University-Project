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
    public partial class F_Student_Courses : Form
    {
        Database db = Database.Instance();
        private Student user;

        public F_Student_Courses()
        {
            InitializeComponent();
            user = (Student)db.USER;
        }

        private void F_Student_Courses_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < user.COURSES.Count; i++)
            {
                ListViewItem Lvi = new ListViewItem(user.COURSES[i].CNAME);
                Lvi.SubItems.Add(user.COURSES[i].POINTS.ToString());
                listView1.Items.Add(Lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
