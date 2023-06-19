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
        public static Network internet = new Network(Form1.ip);
        public static string clientname;
        public static string servername;

        public static string userRole;


        public ServerScreen()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (serverInput.Text != "")
            {

                internet.ServerSide();
                servername = serverInput.Text; 
                userRole = "host";

                Form1.ChangeScreen(this, new ModeScreen());

            }
            else
            {
                createButton.Text = "Enter a username!";
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {

            //internet.ClientSide();


            if (internet.ClientSide() == 0)
            {

                errorLabel.Visible = true;

            }
            else
            {
                userRole = "client";
                errorLabel.Visible = true;
                errorLabel.Text = "connecting...";
                Thread.Sleep(1000);
                Form1.ChangeScreen(this, new ServerHub());

            }
            //if (clientInput.Text == "")
            //{
            //    joinButton.Text = "Enter Username";

            //}
            //else
            //{
            //    clientname = clientInput.Text;
            //    Form1.ChangeScreen(this, new ServerHub());

            //}


        }

    }
}
