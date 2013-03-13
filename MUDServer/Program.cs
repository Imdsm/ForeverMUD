using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MUDServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var listen = true;
            var listener = new TcpListener(IPAddress.Any, 8000);
            
            listener.Start();
            Console.WriteLine("Listening for connections");

            while (listen)
            {                
                if (!listener.Pending())
                {
                    Thread.Sleep(500);
                    continue;
                }

                var client = listener.AcceptTcpClient();
                Console.WriteLine("Connection from {0}", client.Client.RemoteEndPoint.ToString());

                var stream = client.GetStream();

                

                var bytes = Encoding.UTF8.GetBytes("Hello!");
                stream.Write(bytes, 0, bytes.Length);
                client.Close();

                Console.WriteLine("Connection closed");
            }
        }
    }
}
