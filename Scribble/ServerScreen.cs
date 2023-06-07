using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Scribble
{
    public partial class ServerScreen : UserControl
    {
        public ServerScreen()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.63.42.206"), 9050);

            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            newsock.Bind(ipep);

            newsock.Listen(10);

            Form1.client = newsock.Accept();

            Form1.ChangeScreen(this, new ModeScreen());
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.63.42.206"), 9050);
            try
            {
                Form1.server.Connect(ipep);
                Form1.ChangeScreen(this, new ServerHub());
            }
            catch (SocketException)
            {
                errorLabel.Visible = true;
                Refresh();
               
                errorLabel.Visible = false;
                Thread.Sleep(1000);

                

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
