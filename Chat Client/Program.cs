using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Chat_Client;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Chat_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        //TcpClient tcpClient = new TcpClient();
        //StreamReader reader;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Chat());

            
        }

    }
}
