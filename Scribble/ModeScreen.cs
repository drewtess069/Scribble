﻿using System;
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
    public partial class ModeScreen : UserControl
    {
        public static String mode;
        List<String> modes = new List<String> { "Food", "People", "Place", "Object", "Animal", "Phrase", "Action" };
        List<Button> buttons;
        Random randMode = new Random();
        public ModeScreen()
        {
            InitializeComponent();
            buttons = new List<Button> { foodButton, peopleButton, placeButton, objectButton, animalButton, phrasesButton, actionsButton, randomButton};
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ServerHub());
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            mode = modes[0];
            DisplaySelection(mode);
            DisableButton(foodButton);
            
        }

        private void peopleButton_Click(object sender, EventArgs e)
        {
            mode = modes[1];
            DisplaySelection(mode);
            DisableButton(peopleButton);
        }

        private void placeButton_Click(object sender, EventArgs e)
        {
            mode = modes[2];
            DisplaySelection(mode);
            DisableButton(placeButton);
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            mode = modes[4];
            DisplaySelection(mode);
            DisableButton(animalButton);
        }

        private void phrasesButton_Click(object sender, EventArgs e)
        {
            mode = modes[5];
            DisplaySelection(mode);
            DisableButton(phrasesButton);
        }

        private void actionsButton_Click(object sender, EventArgs e)
        {
            mode = modes[6];
            DisplaySelection(mode);
            DisableButton(actionsButton);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            mode = modes[randMode.Next(0, modes.Count - 1)];
            DisplaySelection(mode);
            DisableButton(randomButton);
        }
  

        private void objectButton_Click(object sender, EventArgs e)
        {
            mode = modes[3];
            DisplaySelection(mode);
            DisableButton(objectButton);

        }

        private void DisplaySelection(string mode)
        {
            selectionLabel.Visible = true;
            selectionLabel.Text = $"You have chosen: {mode}";
        }
        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.Green;

            foreach (Button buts in buttons)
            {
                if (buts != button)
                {
                    buts.Enabled = true;
                    buts.BackColor = Color.FromArgb(255, 192, 128);
                }
            }
        }
    }
}
