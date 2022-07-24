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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SimpleTcpServer server;
        private void startButton_Click(object sender, EventArgs e)
        {
            server.Start();
            infoTextBox.Text += $"Starting...{Environment.NewLine}";
            startButton.Enabled = false;
            sendButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sendButton.Enabled = false;
            server = new SimpleTcpServer(ipTextBox.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisConnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                infoTextBox.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}";
            });
        }

        private void Events_ClientDisConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                infoTextBox.Text += $"{e.IpPort} disconnected";
            clientIPListBox.Items.Remove(e.IpPort);

            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                infoTextBox.Text += $"{e.IpPort} connected";
            clientIPListBox.Items.Add(e.IpPort);
            });
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(messageTextBox.Text) && clientIPListBox.SelectedItem != null)
                {
                    server.Send(clientIPListBox.SelectedItem.ToString(),messageTextBox.Text);
                    infoTextBox.Text += $"Server: {messageTextBox.Text}";
                    messageTextBox.Text = String.Empty;
                }
            }
        }
    }
}
