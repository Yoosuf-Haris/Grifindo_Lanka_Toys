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
    public partial class Emp_login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KGK4079/SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public Emp_login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            string querry = "select * from Employees where username='" + txtUsername.Text + "'AND password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                MessageBox.Show("Login Successfully");
                Emp_Dash ed = new Emp_Dash();
                this.Hide();
                ed.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "");
            }
            con.Close();
        }

        private void Emp_login_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Emp_Reg er = new Emp_Reg();
            this.Hide();
            er.Show();
        }
    }
}
