using System;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;

namespace GitHelloWorld
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("你好");
            Console.ReadKey();
            IPAddress address = IPAddress.Parse("192.168.2.103");
            Socket sockerserver = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            sockerserver.Bind(new IPEndPoint(address,7788));

            sockerserver.Listen(100);

            Socket client = sockerserver.Accept();
        }


        private static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
