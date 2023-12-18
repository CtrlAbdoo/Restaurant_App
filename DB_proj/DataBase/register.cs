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

namespace DataBase
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Make sure to fill all required fields.");
                    return; 
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=rest_DBS;Integrated Security=True"))
                    {
                        string query = "INSERT INTO customers (fname, lname, phone, email, pword) VALUES (@fname, @lname, @phone, @email, @pword)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@fname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@lname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                        cmd.Parameters.AddWithValue("@email", textBox4.Text);
                        cmd.Parameters.AddWithValue("@pword", textBox5.Text);

                        con.Open();
                        int n = cmd.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Thank You For using this Application");
                            this.Hide();
                            Login l = new Login();
                            l.Show();
                        }
                        else
                        {
                            MessageBox.Show("Insert failed.");
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
