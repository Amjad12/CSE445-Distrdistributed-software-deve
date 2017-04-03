using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverterApplication
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            // Check if the input in the textbox is an integer
            if (!int.TryParse(textBox1.Text, out input))
            {
                MessageBox.Show("Please, Enter An Integer!");
                return;
            }

            Int32 value = Convert.ToInt32(textBox1.Text);
            TemperService.Service1Client tempSerivce1 = new TemperService.Service1Client();
            var f = tempSerivce1.c2f(value);
            label1.Text = f.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int input1;
            // Check if the input in the textbox is an integer
            if (!int.TryParse(textBox2.Text, out input1))
            {
                MessageBox.Show("Please, Enter An Integer!");
                return;
            }

            Int32 value = Convert.ToInt32(textBox2.Text);
            TemperService.Service1Client tempSerivce1 = new TemperService.Service1Client();
            var c = tempSerivce1.f2c(value);
            label2.Text = c.ToString();
        }

    }
}
