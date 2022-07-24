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
          
            try
            {
                client.Connect();
                sendButton.Enabled = true;
                connectButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(messageTextBox.Text))
                {
                    client.Send(messageTextBox.Text);
                    infoTextBox.Text += $"Server: {messageTextBox.Text}";
                    messageTextBox.Text = String.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(ipTextBox.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            sendButton.Enabled = false;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                infoTextBox.Text += $"Server disconnected";
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                infoTextBox.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}";
            });
        }
    

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate{
                infoTextBox.Text += $"Server connected";
            });
        }
    }
}
