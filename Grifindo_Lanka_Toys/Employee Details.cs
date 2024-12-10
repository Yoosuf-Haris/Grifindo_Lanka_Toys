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
    public partial class Employee_Details : Form
    {
        SqlConnection con = new SqlConnection("Data Source=YOOSUF-HARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public Employee_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dash ad = new Admin_Dash();
            this.Hide();
            ad.Show();
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void fillCombo()
        {
            string sqlcombo;
            sqlcombo = "select emp_ID from Employees";
            SqlDataAdapter da = new SqlDataAdapter(sqlcombo, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbEmpID.DataSource = dt;
            cmbEmpID.ValueMember = "emp_ID";
            cmbEmpID.DisplayMember = "emp_ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlsearch;
            sqlsearch = "select * from Employees where emp_ID ='" + cmbEmpID.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr["emp_name"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtEmpType.Text = dr["emp_type"].ToString();
                txtUsername.Text = dr["username"].ToString();
                txtPassword.Text = dr["password"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert;
                sqlinsert = "insert into Employees(emp_ID,emp_name,email,emp_type,username,password) values " +
                    "('" + cmbEmpID.Text + "','" + txtName.Text + "','" + txtEmail.Text + "','" + txtEmpType.Text + "','" + txtUsername.Text + "'," +
                    "'" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlinsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Inserted sucsessfully!!");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlupdate;
                sqlupdate = " update Employees set emp_name='" + txtName.Text + "',email='" + txtEmail.Text + "',emp_type='" + txtEmpType + "'," +
                    "username='" + txtUsername.Text + "',password='" + txtPassword.Text + "'where emp_id='" + cmbEmpID.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlupdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Updated sucsessfully!!");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string sqldelete;
                    sqldelete = " delete from Employees where emp_ID='" + cmbEmpID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqldelete, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Deleted sucsessfully!!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmpType.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();            
            cmbEmpID.Focus();
        }
    }

}
