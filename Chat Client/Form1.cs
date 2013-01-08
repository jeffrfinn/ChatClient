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
        // tcp socket to connect with server
        static ChatNet.Sockets.TcpClient tcpClient;
        
        // reader to read messages sent from server
        StreamReader reader;

        // background worker used to listen for click on the send button for asynchronus communication 
        private BackgroundWorker backgroundSend;

        // thread for checking and printing new messages
        private Thread messageThread = null;

        public Chat()
        {
            // initialize GUI
            InitializeComponent();
            
            // initialize thread
            tcpClient = new ChatNet.Sockets.TcpClient();
            
            // connect to server on port
            tcpClient.Connect("127.0.0.1", 4296);

            //initialize stream reader to read from tcp connection           
            reader = new StreamReader(tcpClient.GetStream());

            // set up thread to run GetMessages()
            this.messageThread = new Thread(new ThreadStart(this.GetMessage));
            // start the thread
            this.messageThread.Start();
        }

        // when the send button is pressed
        private void SendMsgBtn(object sender, EventArgs e)
        {
            // Let background worker know it is to run
            this.backgroundSend.RunWorkerAsync();
            // GOTO Form1.Designer.cs
        }

        // send the message
        private void SendMessage(object sender, RunWorkerCompletedEventArgs e)
        {
            // if there are lines written
            if (textBox1.Lines.Length > 0)
            {
                // initialize writer to write to tcp connection
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());
                
                // write the line in the text box
                writer.WriteLine(textBox1.Text);
                // flush any remaining bytes
                writer.Flush();
                // clear text in text box
                textBox1.Text = "";
                // set number of lines to null
                textBox1.Lines = null;
            }
 
        }


        // This method is executed on the worker thread and makes 
        // a thread-safe call on the TextBox control. 
        private void GetMessage()
        {
            while (true)
            {
                // print message with the information passed from the server
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
                // print text to chat box
                this.ChatBox.AppendText(s + "\r\n");
            }
        }
   }
}
