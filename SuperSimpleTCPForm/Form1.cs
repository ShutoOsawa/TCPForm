using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace SuperSimpleTCPForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            //Connect to server
            //client.Connect(messageTextBox.Text, Convert.ToInt32(portTextBox.Text));
            
        }
    }
}
