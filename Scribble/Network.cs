using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Drawing;

namespace Scribble
{
   
    public class Network
    {
        string ipadd;
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket client;
        byte[] data;

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

            RecUser();

        }
        public int ClientSide()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ipadd), 9050);

            try
            {
                server.Connect(ipep);
                RecUser();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Sender(int x, int y)
        {
            string recPoint = $"{x},{y}";
            data = Encoding.UTF8.GetBytes(recPoint);
            if (ServerScreen.userRole == "host")
            {
                client.Send(data, data.Length, SocketFlags.None);
            }
            else
            {
                server.Send(data, data.Length, SocketFlags.None);
            }
            
        }
        public Point Receiever()
        {
            int recieve;
            if (ServerScreen.userRole == "client")
            {
                 recieve = server.Receive(data);
            }
            else
            {
                 recieve = client.Receive(data);
            }
            string stringPoint = $"{Encoding.UTF8.GetString(data, 0, recieve)}";
            int index = stringPoint.IndexOf(",");
            string x = stringPoint.Substring(0, index);
            string y = stringPoint.Substring(index + 1);
            return new Point(Convert.ToInt16(x), Convert.ToInt16(y));
        }

        public void sendUser(string username)
        {
            data = Encoding.UTF8.GetBytes(username);
            if (ServerScreen.userRole == "host")
            {
                client.Send(data, data.Length, SocketFlags.None);
            }
            else
            {
                server.Send(data, data.Length, SocketFlags.None);
            }
        }

        public string RecUser()
        {
            int recieve;
            if (ServerScreen.userRole == "client")
            {
                recieve = server.Receive(data);
            }
            else
            {
                recieve = client.Receive(data);
            }
            string username = $"{Encoding.UTF8.GetString(data, 0, recieve)}";

            return username;
        }
    }
}
