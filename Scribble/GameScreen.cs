﻿using System;
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
using System.Windows.Forms.VisualStyles;

namespace Scribble
{
    public partial class GameScreen : UserControl
    {
        List<string> wordList = new List<string>();
        List<string> selectedWords = new List<string>();
        Random wordGen = new Random();
        string word;
        string gameState;
        string role;
        int roundCount;
        int gameCount;
        bool mouseDown;
        bool paintingEnabled;
        Graphics g;
        int? initx = null;
        int? inity = null;

        public GameScreen()
        {
            InitializeComponent();
            WordSelect();
            g = drawLabel.CreateGraphics();
            gameState = "roundStart";
        }

        public void NewRound()
        {

        }

        public void WordSelect()
        {
            wordList = File.ReadAllLines($"Resources\\{ModeScreen.mode}File.txt").ToList();

            for (int i = 0; i < 3; i++)
            {
                int index = wordGen.Next(0, wordList.Count);
                string randomWord = wordList[index];
                selectedWords.Add(randomWord.ToLower());
            }

            word1Button.Text = selectedWords[0];
            word2Button.Text = selectedWords[1];
            word3Button.Text = selectedWords[2];

            word1Button.Enabled = true;
            word2Button.Enabled = true;
            word3Button.Enabled = true;

            word1Button.Visible = true;
            word2Button.Visible = true;
            word3Button.Visible = true;

            wordTitleLabel.Visible = true;

            Refresh();
        }

        private void word1Button_Click(object sender, EventArgs e)
        {
            word = word1Button.Text;
            DisableButtons();
            DisplayWord();
            paintingEnabled = true;
        }

        private void word2Button_Click(object sender, EventArgs e)
        {
            word = word2Button.Text;
            DisableButtons();
            DisplayWord();
            paintingEnabled = true;
        }

        private void word3Button_Click(object sender, EventArgs e)
        {
            word = word3Button.Text;
            DisableButtons();
            DisplayWord();
            paintingEnabled = true;
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
            wordLabel.Text = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    wordLabel.Text += "   ";
                }
                else
                {
                    wordLabel.Text += "_ ";
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void drawLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (paintingEnabled)
            {
                mouseDown = true;
            }
        }

        private void drawLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, new Point(initx ?? e.X, inity ?? e.Y), new Point(e.X, e.Y));
                initx = e.X;
                inity = e.Y;
               


            }
            

        }

        private void drawLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            initx = null;
            inity = null;
        }
    }
}
