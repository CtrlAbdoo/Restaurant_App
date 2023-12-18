using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\local;Initial Catalog=rest_DBS;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM employees WHERE phone = @phone AND password = @password", con))
                {
                    cmd.Parameters.AddWithValue("@phone", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);

                    try
                    {
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                this.Hide();
                                order o = new order(); 
                                o.Show();
                            }
                            else
                            {
                                MessageBox.Show("This user does not exist");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register r = new register(); // Assuming you have a form named 'Register'
            this.Hide();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            ForgetPassword f = new ForgetPassword();
            this.Hide();
            f.Show();
            
        }
    }
}
