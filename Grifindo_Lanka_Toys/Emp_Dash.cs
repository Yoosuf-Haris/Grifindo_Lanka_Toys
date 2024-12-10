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
    public partial class Emp_Dash : Form
    {
        int employeeID;
        public Emp_Dash()
        {
            InitializeComponent();
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            Apply_Leave al = new Apply_Leave(employeeID);
            this.Hide();
            al.Show();
        }

        private void btnLeaveStatus_Click(object sender, EventArgs e)
        {
            View_Leave_Status ls = new View_Leave_Status(employeeID);
            this.Hide();
            ls.Show();

        }

        private void btnLeaveHistory_Click(object sender, EventArgs e)
        {
            View_leave_history lh = new View_leave_history(employeeID);
            this.Hide();
            lh.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Emp_login ed = new Emp_login();
            this.Hide();
            ed.Show();
        }

        private void Emp_Dash_Load(object sender, EventArgs e)
        {

        }
    }
}
