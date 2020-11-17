using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace StresserClient
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StresserClient());

            Client client = new Client("76.93.145.158", 80);

            //for (int i = 0; i<500; i++)
            //{
            //    new Thread(() =>
            //    {
            //        Thread.CurrentThread.IsBackground = true;

            //        while (true)
            //        {
            //            try
            //            {
            //                client.Send();
            //            }
            //            catch
            //            {
            //                // Target is down
            //                Console.WriteLine("Target is down");
            //            }
            //        }
            //    }).Start();
            //}
        }
    }
}
