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
    public partial class Admin_Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MUHAMMEDH\\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_Toys;Integrated Security=True");
        SqlCommand cmd;

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            string querry = "select * from Admin_Details where username='" + txtUsername.Text + "'AND password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                MessageBox.Show("Login Successfully");
                Admin_Dash ad = new Admin_Dash();
                this.Hide();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "");
            }
            con.Close();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
