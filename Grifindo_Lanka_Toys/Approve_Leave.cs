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
    public partial class Approve_Leave : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public Approve_Leave()
        {
            InitializeComponent();
        }

        private void Approve_Leave_Load(object sender, EventArgs e)
        {
            string query = "SELECT LeaveID, LeaveType, StartDate,EndDate, Status FROM LeaveApplication WHERE Status = 'Pending'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewLeaveRequests.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dash ad = new Admin_Dash();
            this.Hide();
            ad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridViewLeaveRequests.SelectedRows.Count > 0)
            {
                int leave_ID = Convert.ToInt32(dataGridViewLeaveRequests.SelectedRows[0].Cells["LeaveID"].Value);
                UpdateLeaveStatus(leave_ID,"Approved");
                MessageBox.Show("Leave Appoved");
            }
            else
            {
                MessageBox.Show("Please select a leave request to approve.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dataGridViewLeaveRequests.SelectedRows.Count > 0)
            {
                int leaveID = Convert.ToInt32(dataGridViewLeaveRequests.SelectedRows[0].Cells["LeaveID"].Value);
                UpdateLeaveStatus(leaveID, "Rejected");
                MessageBox.Show("Leave Rejected");


            }
            else
            {
                MessageBox.Show("Please select a leave request to reject.");
            }
        }

        // Update the status of a leave request
        private void UpdateLeaveStatus(int leaveID, string status)
        {

            string query = "UPDATE LeaveApplication SET Status = @status WHERE LeaveID = LeaveID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("Status", status);
            cmd.Parameters.AddWithValue("LeaveID", leaveID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Approve_Leave al = new Approve_Leave();
            this.Hide();
            al.Show();
        }
    }
}
