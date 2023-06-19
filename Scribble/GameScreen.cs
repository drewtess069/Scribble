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
        List<string> role = new List<string>();
        int round = 0;
        int gameCount;
        bool mouseDown;
        bool paintingEnabled = false;
        Graphics g;
        int? initx = null;
        int? inity = null;
        Pen drawPen = new Pen(Color.Black, 5);

        int timerTick;
        int roundTime = 60;


        public GameScreen()
        {
            InitializeComponent();
            g = drawLabel.CreateGraphics();
            NewRound();
            WordSelect();
            gameState = "roundStart";
        }

        public void NewRound()
        {
            timerTick = 0;
            selectedWords.Clear();
            wordList.Clear();
            roundTime = 60;

            for (int i = 0; i < ServerHub.players.Count; i++)
            {
                if (i == round)
                {
                    role[i] = "painter";
                }
                else
                {
                    role[i] = "player";
                }
            }
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

            //for (int i = 0; i < role.Count; i++)
            //{
            wordTitleLabel.Visible = true;

            //if (role[i] == "painter")
            //{
            wordTitleLabel.Text = "Please Select a Word.";

            word1Button.Text = selectedWords[0];
            word2Button.Text = selectedWords[1];
            word3Button.Text = selectedWords[2];

            word1Button.Enabled = true;
            word2Button.Enabled = true;
            word3Button.Enabled = true;

            word1Button.Visible = true;
            word2Button.Visible = true;
            word3Button.Visible = true;

            Refresh();
            //}
            //else
            //{
            //    wordTitleLabel.Text = "Waiting for painter.";
            //}
            //}
        }

        private void word1Button_Click(object sender, EventArgs e)
        {
            word = word1Button.Text;
            DisableButtons();
            DisplayWord();
            gameTimer.Enabled = true;
        }

        private void word2Button_Click(object sender, EventArgs e)
        {
            word = word2Button.Text;
            DisableButtons();
            DisplayWord();
            gameTimer.Enabled = true;
        }

        private void word3Button_Click(object sender, EventArgs e)
        {
            word = word3Button.Text;
            DisableButtons();
            DisplayWord();
            gameTimer.Enabled = true;
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
            timerTick++;
            if (timerTick != 0 && timerTick % 50 == 0)
            {
                roundTime--;
                timeLabel.Text = roundTime.ToString();
            }

            if (roundTime == 0)
            {
                gameTimer.Stop();
                round++;
            }

            for (int i = 0; i < role.Count; i++)
            {

            }

        }

        private void drawLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameTimer.Enabled)
            {
                mouseDown = true;
            }
        }

        private void drawLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Pen p = new Pen(Color.Black);
                g.DrawLine(drawPen, new Point(initx ?? e.X, inity ?? e.Y), new Point(e.X, e.Y));
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

        private void guessInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && guessInput.Text != null && guessInput.Text != "")
            {

                if (guessInput.Text == word)
                {
                    guessesLabel.Text += $"\n USERNAME guessed the word!";
                    guessInput.Clear();
                }
                else
                {
                    guessesLabel.Text = $"\n INSERT USERNAME HERE: {guessInput.Text}";
                }
            }
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Red);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Orange);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Yellow);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Green);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Blue);
        }

        private void purpleLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Purple);
        }

        private void brownLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.SaddleBrown);
        }

        private void blackLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.Black);
        }

        private void eraserLabel_Click(object sender, EventArgs e)
        {
            drawColour(Color.White);
        }

        private void drawColour(Color c)
        {
            drawPen.Color = c;
            drawPen.Width = 5;
            if (c == Color.White) { drawPen.Width = 10; }
        }

        private void TheButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
