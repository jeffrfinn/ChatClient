using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using ChatNet = System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Chat_Client
{
    public partial class Chat : Form
    {
        static ChatNet.Sockets.TcpClient tcpClient;
        StreamReader reader;

        private BackgroundWorker backgroundSend;

        private Thread messageThread = null;

        public Chat()
        {
            InitializeComponent();
                        
            tcpClient = new ChatNet.Sockets.TcpClient();
            tcpClient.Connect("127.0.0.1", 4296);
           
            reader = new StreamReader(tcpClient.GetStream());

            this.messageThread = new Thread(new ThreadStart(this.GetMessage));

            this.messageThread.Start();
        }

        private void SendMsgBtn(object sender, EventArgs e)
        {
            this.backgroundSend.RunWorkerAsync();
        }

        private void SendMessage(object sender, RunWorkerCompletedEventArgs e)
        {
           if (textBox1.Lines.Length > 0)
            {
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());

                writer.WriteLine(textBox1.Text);

                writer.Flush();

                textBox1.Text = "";

                textBox1.Lines = null;
            }
 
        }


        // This method is executed on the worker thread and makes 
        // a thread-safe call on the TextBox control. 
        private void GetMessage()
        {
            while (true)
            {
                this.PrintMessage(reader.ReadLine());
            }
        }

        delegate void SetTextCallback(string text);

        private void PrintMessage(string s)
        {
            
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ChatBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(PrintMessage);
              this.Invoke(d, new object[] { s });
            }
            else
            {
                this.ChatBox.AppendText(s + "\r\n");
            }
        }
   }
}
