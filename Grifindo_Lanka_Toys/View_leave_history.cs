using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Lanka_Toys
{
    public partial class View_leave_history : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public View_leave_history(int employeeID)
        {
            InitializeComponent();
        }

        

        private void View_leave_history_Load(object sender, EventArgs e)
        {
            Emp_Dash ed = new Emp_Dash();
            this.Hide();
            ed.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string sqlsearch;
            sqlsearch = "select LeaveID, LeaveType, StartDate, EndDate, Status, DateApplied from LeaveApplication where LeaveID ='" + txtLeaveID.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}
