namespace Scribble
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
            this.pencilLabel = new System.Windows.Forms.PictureBox();
            this.eraserLabel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pencilLabel)).BeginInit();
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
            this.drawLabel.Location = new System.Drawing.Point(388, 108);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(1095, 847);
            this.drawLabel.TabIndex = 2;
            // 
            // guessInput
            // 
            this.guessInput.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInput.Location = new System.Drawing.Point(1518, 1001);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(344, 56);
            this.guessInput.TabIndex = 3;
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
            this.redLabel.Location = new System.Drawing.Point(388, 982);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(75, 75);
            this.redLabel.TabIndex = 7;
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueLabel.Location = new System.Drawing.Point(893, 982);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(75, 75);
            this.blueLabel.TabIndex = 8;
            // 
            // purpleLabel
            // 
            this.purpleLabel.BackColor = System.Drawing.Color.Purple;
            this.purpleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purpleLabel.Location = new System.Drawing.Point(1028, 982);
            this.purpleLabel.Name = "purpleLabel";
            this.purpleLabel.Size = new System.Drawing.Size(75, 75);
            this.purpleLabel.TabIndex = 9;
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blackLabel.Location = new System.Drawing.Point(1155, 982);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(75, 75);
            this.blackLabel.TabIndex = 10;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenLabel.Location = new System.Drawing.Point(767, 982);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(75, 75);
            this.greenLabel.TabIndex = 13;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yellowLabel.Location = new System.Drawing.Point(636, 982);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(75, 75);
            this.yellowLabel.TabIndex = 14;
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orangeLabel.Location = new System.Drawing.Point(509, 982);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(75, 75);
            this.orangeLabel.TabIndex = 15;
            // 
            // pencilLabel
            // 
            this.pencilLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pencilLabel.BackgroundImage = global::Scribble.Properties.Resources.image_processing20200423_22926_hjypki;
            this.pencilLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencilLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pencilLabel.Location = new System.Drawing.Point(1280, 982);
            this.pencilLabel.Name = "pencilLabel";
            this.pencilLabel.Size = new System.Drawing.Size(75, 75);
            this.pencilLabel.TabIndex = 16;
            this.pencilLabel.TabStop = false;
            // 
            // eraserLabel
            // 
            this.eraserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eraserLabel.BackgroundImage = global::Scribble.Properties.Resources._595_5956276_png_photo_pencil_eraser_color_clip_art_colour;
            this.eraserLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eraserLabel.Location = new System.Drawing.Point(1408, 982);
            this.eraserLabel.Name = "eraserLabel";
            this.eraserLabel.Size = new System.Drawing.Size(75, 75);
            this.eraserLabel.TabIndex = 17;
            this.eraserLabel.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 103);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose a Word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 83);
            this.button1.TabIndex = 19;
            this.button1.Text = "Word 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(840, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 83);
            this.button2.TabIndex = 20;
            this.button2.Text = "word 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1155, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 83);
            this.button3.TabIndex = 21;
            this.button3.Text = "word 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eraserLabel);
            this.Controls.Add(this.pencilLabel);
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
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.pencilLabel)).EndInit();
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
        private System.Windows.Forms.PictureBox pencilLabel;
        private System.Windows.Forms.PictureBox eraserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
