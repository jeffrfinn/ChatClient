using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;


namespace Chat_Client
{
    public partial class Chat : Form
    {
        static TcpClient tcpClient;
        

        public Chat()
        {
            InitializeComponent();
            tcpClient.Connect("local", 4296);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetServer(object sender, EventArgs e)
        {
            tcpClient.Connect(ServerName.Text,4296);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (ChatBox.Lines.Length > 0)
            {
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());

                writer.WriteLine(ChatBox.Text);

                writer.Flush();

                ChatBox.Text = "";

                ChatBox.Lines = null;


            }
        }

    }
}
