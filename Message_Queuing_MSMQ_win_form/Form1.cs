using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Queuing_MSMQ_win_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.StockQuoteSoapClient scl = new ServiceReference1.StockQuoteSoapClient();

           // string name = textBox1.Text;
            string data = scl.GetQuote(textBox1.Text);

            textBox2.Text = data;

            }
    }
}
