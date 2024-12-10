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
    public partial class Emp_Reg : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public Emp_Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp_login el = new Emp_login();
            this.Hide();
            el.Show();
        }

        private void Emp_Reg_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL query with parameters instead of direct values
                string sqlinsert = "INSERT INTO Employees (Emp_Name, Email, Emp_Type, Username, Password) " +
                                   "VALUES (@EmpName, @Email, @EmpType, @Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(sqlinsert, con))
                {
                    // Add parameters with values from TextBox controls
                    cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@EmpType", txtEmpType.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();  // Execute the query
                    MessageBox.Show("Registered successfully!!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Show any exception message
            }
            finally
            {
                con.Close();  // Always close the connection in the finally block to ensure it's closed even if an error occurs
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmpType.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtEmpID.Clear();
        }
    }
}
