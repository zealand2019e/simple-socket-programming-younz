using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace EchoServer
{
   public static class Server
    {
        public static void Start()
        {
            TcpListener socketServer = new TcpListener(IPAddress.Any, port: 7777); // forbundet med port 7777
            
            socketServer.Start();
            // start sever

            // accept client
            TcpClient connectionSocket = socketServer.AcceptTcpClient();
            Console.WriteLine("server activated");
            DoClient(connectionSocket);

            connectionSocket.Close();
            socketServer.Stop();
            
            
            
            



        }

        private static void DoClient(TcpClient connectionSocket)
        {
            Stream ns = connectionSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            string line = sr.ReadLine();
            if (line != null)
            {
                sw.WriteLine(line.ToUpper());
            }
        }
    }
}