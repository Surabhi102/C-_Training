using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          


        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            int sum = no1+no2;
            textBox3.Text = textBox3.Text+sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            int sum = no1 - no2;
            textBox3.Text = textBox3.Text + sum.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            float sum = no1 / no2;
            textBox3.Text = textBox3.Text + sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int no1 = Convert.ToInt32(textBox1.Text);
            int no2 = Convert.ToInt32(textBox2.Text);
            int sum = no1 * no2;
            textBox3.Text = textBox3.Text + sum.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
