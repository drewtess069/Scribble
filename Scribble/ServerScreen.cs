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
        Network internet = new Network(Form1.ip);
        
        public ServerScreen()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //internet.ServerSide();
           

            Form1.ChangeScreen(this, new ModeScreen());
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            
            if (internet.ClientSide() == 0)
            {
                
                errorLabel.Visible = true;
                
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Connecting...";
                Thread.Sleep(1000);
                Form1.ChangeScreen(this, new ModeScreen());
            }
            
        }

    }
}
