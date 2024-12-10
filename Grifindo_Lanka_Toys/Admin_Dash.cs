using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys
{
    public partial class Admin_Dash : Form
    {
        public Admin_Dash()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Employee_Details ed = new Employee_Details();
            this.Hide();
            ed.Show();
        }

        private void btnManageLeave_Click(object sender, EventArgs e)
        {
            Approve_Leave al = new Approve_Leave();
            this.Hide();
            al.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            View_Report vr = new View_Report();
            this.Hide();
            vr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            this.Hide();
            al.Show();
        }
    }
}
