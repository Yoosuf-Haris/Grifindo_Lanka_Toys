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
    public partial class View_Leave_Status : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public View_Leave_Status(int employeeID)
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Emp_Dash ed = new Emp_Dash();
            this.Hide();
            ed.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sqlsearch;

            // If textBox1 is empty, fetch all customer details
            if (string.IsNullOrEmpty(lveId.Text))
            {
                sqlsearch = "SELECT * FROM LeaveApplication";
            }
            else
            {
                // If textBox1 is not empty, search by CustomerID
                sqlsearch = "SELECT * FROM LeaveApplication WHERE LeaveID ='" + lveId.Text + "'";
            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
