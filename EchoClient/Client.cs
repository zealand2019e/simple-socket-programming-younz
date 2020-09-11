using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Client
    {
        public static void start()
        {
            TcpClient socketClient = new TcpClient(hostname:"localhost",port: 7777);
            Stream ns = socketClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            
            sw.AutoFlush = true;

            Console.WriteLine("indtast besked");
            string message = Console.ReadLine();
            sw.WriteLine(message);

        }
    }
}
