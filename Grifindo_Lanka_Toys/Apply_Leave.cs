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
    public partial class Apply_Leave : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;


        public Apply_Leave(int employeeID)
        {
            InitializeComponent();
            InitializeLeaveTypeComboBox(); // Initialize leave types in the combo box
        }

        private void InitializeLeaveTypeComboBox()
        {
            cmbLeaveType.Items.Add("Annual Leave");
            cmbLeaveType.Items.Add("Casual Leave");
            cmbLeaveType.Items.Add("Short Leave");
        }

        private void Apply_Leave_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbLeaveType.SelectedItem == null)
            {
                MessageBox.Show("Please select a leave type.");
                return;
            }

            // Get values from input controls
            string leaveType = cmbLeaveType.SelectedItem.ToString();
            DateTime startDate = dateTimePickerSDate.Value;
            DateTime endDate = dateTimePickerEDate.Value;

            // Validate leave dates
            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than start date.");
                return;
            }

            // Calculate the number of leave days
            int leaveDays = (endDate - startDate).Days + 1;  // Include both start and end date in the count

            // Insert leave application with auto-filled "Pending" status and calculated "LeaveDays"
            string query = "INSERT INTO LeaveApplication (Emp_ID, LeaveType, StartDate, EndDate, Status, LeaveDays, DateApplied) " +
                           "VALUES (@empID, @leaveType, @startDate, @endDate, @status, @leaveDays, @leaveAppliedDate)";

            DateTime leaveAppliedDate = DateTime.Now;

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Ensure you're passing the employeeID from the constructor
                cmd.Parameters.AddWithValue("@empID", empId.Text);  // Assuming you have this value from the constructor
                cmd.Parameters.AddWithValue("@leaveType", leaveType);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@status", "Pending");  // Automatically set the status to "Pending"
                cmd.Parameters.AddWithValue("@leaveDays", leaveDays);  // Automatically calculate leave days
                cmd.Parameters.AddWithValue("@leaveAppliedDate", leaveAppliedDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Leave application submitted successfully");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Emp_Dash ed = new Emp_Dash();
            this.Hide();
            ed.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
