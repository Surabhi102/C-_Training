using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Running");

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            string strTemp;
            strTemp = await DownloadTemperature();
            label.Text = strTemp;
            


        }
        private async Task<string> DownloadTemperature()
        {
            string strTemp;
            await Task.Delay(10000);
            strTemp = "34";
            return strTemp;
        }
    }
}
