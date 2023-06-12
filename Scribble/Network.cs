﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Scribble
{
   
    internal class Network
    {
        string ipadd;
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket client;

        public Network(string _ipadd)
        {
            ipadd = _ipadd;
        }

        public void ServerSide()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ipadd), 9050);

            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            newsock.Bind(ipep);

            newsock.Listen(10);

            client = newsock.Accept();

        }
        public int ClientSide()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ipadd), 9050);

            try
            {
                server.Connect(ipep);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}