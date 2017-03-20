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
    public partial class F_Head_Department_Graduates : Form
    {
        Database db = Database.Instance();
        private DataTable dt;
        private HeadDept user;

        public F_Head_Department_Graduates()
        {
            InitializeComponent();
            user = (HeadDept)db.USER;
            dt = new DataTable();
        }

        private void F_Head_Department_Graduates_Load(object sender, EventArgs e)
        {
            dt = db.FetchTable(db.TGRADUATES, "*" , "Average >= 0").Tables[db.TGRADUATES];
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
