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
    public partial class View_Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public View_Report()
        {
            InitializeComponent();
            InitializeEmpIDComboBox(); // Initialize report type options
        }

        private void InitializeEmpIDComboBox()
        {
            cmbEmpID.Items.Add("Individual Employee");
            cmbEmpID.Items.Add("All Employees");
        }

        private void View_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string employeeType = cmbEmpID.SelectedItem.ToString(); // Get selected employee type
            DateTime startDate = dateTimePickerSdate.Value; // Get selected start date
            DateTime endDate = dateTimePickerEDate.Value;     // Get selected end date

            // Ensure valid date range
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate the report
            GenerateLeaveReport(employeeType, startDate, endDate);
        }

        // Method to generate leave report
        private void GenerateLeaveReport(string employeeType, DateTime startDate, DateTime endDate)
        {
            
                try
                {
                    con.Open();

                    string query = "SELECT emp_ID, LeaveType, StartDate, EndDate, Status FROM LeaveApplication " +
                                   "WHERE StartDate >= @StartDate AND EndDate <= @EndDate";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewReports.DataSource = dt; // Bind data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating report: " + ex.Message);
                    con.Close();

                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dash ad = new Admin_Dash();
            this.Hide();
            ad.Show();
        }
    }
}
