using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form1.ChangeScreen(this, new ModeScreen());
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ServerHub());
        }
    }
}
