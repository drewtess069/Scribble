﻿namespace Scribble
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerLabel = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerTitle = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.purpleLabel = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.eraserLabel = new System.Windows.Forms.PictureBox();
            this.wordTitleLabel = new System.Windows.Forms.Label();
            this.word1Button = new System.Windows.Forms.Button();
            this.word2Button = new System.Windows.Forms.Button();
            this.word3Button = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.TheButton = new System.Windows.Forms.Button();
            this.brownLabel = new System.Windows.Forms.Label();
            this.clientEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eraserLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.playerLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(23, 108);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(344, 949);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "label1";
            // 
            // guessesLabel
            // 
            this.guessesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guessesLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLabel.Location = new System.Drawing.Point(1519, 108);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(344, 836);
            this.guessesLabel.TabIndex = 1;
            this.guessesLabel.Text = "label2";
            // 
            // drawLabel
            // 
            this.drawLabel.BackColor = System.Drawing.Color.White;
            this.drawLabel.Location = new System.Drawing.Point(388, 141);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(1108, 814);
            this.drawLabel.TabIndex = 2;
            this.drawLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawLabel_MouseDown);
            this.drawLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawLabel_MouseMove);
            this.drawLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawLabel_MouseUp);
            // 
            // guessInput
            // 
            this.guessInput.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInput.Location = new System.Drawing.Point(1518, 1001);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(344, 56);
            this.guessInput.TabIndex = 3;
            this.guessInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessInput_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1518, 944);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Guess Here";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTitle
            // 
            this.playerTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.playerTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTitle.Location = new System.Drawing.Point(23, 18);
            this.playerTitle.Name = "playerTitle";
            this.playerTitle.Size = new System.Drawing.Size(344, 90);
            this.playerTitle.TabIndex = 5;
            this.playerTitle.Text = "Player List:";
            this.playerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(1638, 40);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 53);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redLabel.Location = new System.Drawing.Point(391, 982);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(57, 59);
            this.redLabel.TabIndex = 7;
            this.redLabel.Tag = "1";
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueLabel.Location = new System.Drawing.Point(851, 984);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(60, 59);
            this.blueLabel.TabIndex = 8;
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // purpleLabel
            // 
            this.purpleLabel.BackColor = System.Drawing.Color.Purple;
            this.purpleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purpleLabel.Location = new System.Drawing.Point(957, 984);
            this.purpleLabel.Name = "purpleLabel";
            this.purpleLabel.Size = new System.Drawing.Size(61, 59);
            this.purpleLabel.TabIndex = 9;
            this.purpleLabel.Click += new System.EventHandler(this.purpleLabel_Click);
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blackLabel.Location = new System.Drawing.Point(1066, 984);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(64, 59);
            this.blackLabel.TabIndex = 10;
            this.blackLabel.Click += new System.EventHandler(this.blackLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenLabel.Location = new System.Drawing.Point(743, 984);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(54, 57);
            this.greenLabel.TabIndex = 13;
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yellowLabel.Location = new System.Drawing.Point(620, 984);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(59, 57);
            this.yellowLabel.TabIndex = 14;
            this.yellowLabel.Tag = "3";
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orangeLabel.Location = new System.Drawing.Point(506, 982);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(59, 59);
            this.orangeLabel.TabIndex = 15;
            this.orangeLabel.Tag = "2";
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // eraserLabel
            // 
            this.eraserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eraserLabel.BackgroundImage = global::Scribble.Properties.Resources._595_5956276_png_photo_pencil_eraser_color_clip_art_colour;
            this.eraserLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eraserLabel.Location = new System.Drawing.Point(1186, 982);
            this.eraserLabel.Name = "eraserLabel";
            this.eraserLabel.Size = new System.Drawing.Size(58, 61);
            this.eraserLabel.TabIndex = 17;
            this.eraserLabel.TabStop = false;
            this.eraserLabel.Click += new System.EventHandler(this.eraserLabel_Click);
            // 
            // wordTitleLabel
            // 
            this.wordTitleLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.wordTitleLabel.Enabled = false;
            this.wordTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTitleLabel.Location = new System.Drawing.Point(529, 320);
            this.wordTitleLabel.Name = "wordTitleLabel";
            this.wordTitleLabel.Size = new System.Drawing.Size(804, 103);
            this.wordTitleLabel.TabIndex = 18;
            this.wordTitleLabel.Text = "Choose a Word";
            this.wordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordTitleLabel.Visible = false;
            // 
            // word1Button
            // 
            this.word1Button.Enabled = false;
            this.word1Button.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1Button.Location = new System.Drawing.Point(533, 500);
            this.word1Button.Name = "word1Button";
            this.word1Button.Size = new System.Drawing.Size(264, 331);
            this.word1Button.TabIndex = 19;
            this.word1Button.Text = "Word 1";
            this.word1Button.UseVisualStyleBackColor = true;
            this.word1Button.Visible = false;
            this.word1Button.Click += new System.EventHandler(this.word1Button_Click);
            // 
            // word2Button
            // 
            this.word2Button.Enabled = false;
            this.word2Button.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2Button.Location = new System.Drawing.Point(823, 500);
            this.word2Button.Name = "word2Button";
            this.word2Button.Size = new System.Drawing.Size(249, 331);
            this.word2Button.TabIndex = 20;
            this.word2Button.Text = "word 2";
            this.word2Button.UseVisualStyleBackColor = true;
            this.word2Button.Visible = false;
            this.word2Button.Click += new System.EventHandler(this.word2Button_Click);
            // 
            // word3Button
            // 
            this.word3Button.Enabled = false;
            this.word3Button.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3Button.Location = new System.Drawing.Point(1095, 500);
            this.word3Button.Name = "word3Button";
            this.word3Button.Size = new System.Drawing.Size(238, 331);
            this.word3Button.TabIndex = 21;
            this.word3Button.Text = "word 3";
            this.word3Button.UseVisualStyleBackColor = true;
            this.word3Button.Visible = false;
            this.word3Button.Click += new System.EventHandler(this.word3Button_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.ForeColor = System.Drawing.Color.Black;
            this.wordLabel.Location = new System.Drawing.Point(388, 18);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(1108, 109);
            this.wordLabel.TabIndex = 22;
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // TheButton
            // 
            this.TheButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheButton.Location = new System.Drawing.Point(1294, 982);
            this.TheButton.Name = "TheButton";
            this.TheButton.Size = new System.Drawing.Size(97, 56);
            this.TheButton.TabIndex = 23;
            this.TheButton.Text = "Clear";
            this.TheButton.UseVisualStyleBackColor = true;
            this.TheButton.Click += new System.EventHandler(this.TheButton_Click);
            // 
            // brownLabel
            // 
            this.brownLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.brownLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brownLabel.Location = new System.Drawing.Point(1724, 1474);
            this.brownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brownLabel.Name = "brownLabel";
            this.brownLabel.Size = new System.Drawing.Size(112, 112);
            this.brownLabel.TabIndex = 23;
            this.brownLabel.Click += new System.EventHandler(this.brownLabel_Click);
            // 
            // clientEnable
            // 
            this.clientEnable.Location = new System.Drawing.Point(31, 1001);
            this.clientEnable.Name = "clientEnable";
            this.clientEnable.Size = new System.Drawing.Size(135, 49);
            this.clientEnable.TabIndex = 24;
            this.clientEnable.Text = "Client Begin";
            this.clientEnable.UseVisualStyleBackColor = true;
            this.clientEnable.Click += new System.EventHandler(this.clientEnable_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.clientEnable);
            this.Controls.Add(this.TheButton);
            this.Controls.Add(this.brownLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.word3Button);
            this.Controls.Add(this.word2Button);
            this.Controls.Add(this.word1Button);
            this.Controls.Add(this.wordTitleLabel);
            this.Controls.Add(this.eraserLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.purpleLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.playerTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.playerLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.eraserLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerTitle;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label purpleLabel;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.PictureBox eraserLabel;
        private System.Windows.Forms.Label wordTitleLabel;
        private System.Windows.Forms.Button word1Button;
        private System.Windows.Forms.Button word2Button;
        private System.Windows.Forms.Button word3Button;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Timer gameTimer;

        private System.Windows.Forms.Button TheButton;

        private System.Windows.Forms.Label brownLabel;
        private System.Windows.Forms.Button clientEnable;
    }
}
