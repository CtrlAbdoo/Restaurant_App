using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class order : Form
    {
        int price = 0;
               
        public order()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price += 25;
            textBox1.Text = Convert.ToString(price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            price += 30;
            textBox1.Text = Convert.ToString(price);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            price += 120;
            textBox1.Text = Convert.ToString(price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            price += 120;
            textBox1.Text = Convert.ToString(price);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            price += 150;
            textBox1.Text = Convert.ToString(price);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            price += 40;
            textBox1.Text = Convert.ToString(price);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            price += 70;
            textBox1.Text = Convert.ToString(price);
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order compeleted thank you for using our application");
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();

        }
    }
}
