using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Scribble
{
    public partial class GameScreen : UserControl
    {
        List<string> wordList= new List<string>();
        List<string> selectedWords= new List<string>();
        Random wordGen = new Random();
        string word;

        public GameScreen()
        {
            InitializeComponent();

        }

        public void NewRound()
        {

        }

        public void WordSelect()
        {
           wordList = File.ReadAllLines($"{ModeScreen.mode}.txt").ToList();

            for(int i = 0; i < 3; i++)
            {
                int index = wordGen.Next(0, wordList.Count);
                selectedWords[i] = wordList[index];
            }

            word1Button.Text = selectedWords[0];
            word2Button.Text = selectedWords[1];
            word3Button.Text = selectedWords[2];

            word1Button.Enabled = true;
            word2Button.Enabled = true;
            word3Button.Enabled = true;

            word1Button.Visible= true;
            word2Button.Visible = true;
            word3Button.Visible = true;

            wordTitleLabel.Visible = true;

            Refresh();
        }

        private void word1Button_Click(object sender, EventArgs e)
        {
            word = word1Button.Text;
            DisableButtons();
        }

        private void word2Button_Click(object sender, EventArgs e)
        {
            word = word2Button.Text;
            DisableButtons();
        }

        private void word3Button_Click(object sender, EventArgs e)
        {
            word = word3Button.Text;
            DisableButtons();
        }

        public void DisableButtons()
        {
            word1Button.Enabled = false;
            word2Button.Enabled = false;
            word3Button.Enabled = false;

            word1Button.Visible = false;
            word2Button.Visible = false;
            word3Button.Visible = false;
            wordTitleLabel.Visible = false;
        }

        public void DisplayWord()
        {
            for (int i = 0; i < word.Length; i++)
            {
                wordLabel.Text += "__ ";
            }
        }
    }
}
