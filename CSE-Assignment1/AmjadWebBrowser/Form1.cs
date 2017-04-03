using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmjadWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
           
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AspProxyToWcf.ServiceClient myClient = new AspProxyToWcf.ServiceClient();
            try
            {
                label4.Text = myClient.Encrypt(textBox1.Text);
            }
            catch (Exception ec)
            {
                label4.Text = ec.Message.ToString();
            }
            try
            {
                label5.Text = myClient.Decrypt(label4.Text);
            }
            catch (Exception dc)
            {
                label5.Text = dc.Message.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockService.ServiceClient stk = new StockService.ServiceClient();
            try
            {
                label6.Text = stk.getStockquote(textBox2.Text);
            }
            catch (Exception ec)
            {
                label6.Text = ec.Message.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
