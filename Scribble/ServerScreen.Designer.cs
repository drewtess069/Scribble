﻿namespace Scribble
{
    partial class ServerScreen
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
            this.leftBackLabel = new System.Windows.Forms.Label();
            this.rightBackLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.joinLabel = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.clientInput = new System.Windows.Forms.TextBox();
            this.serverInput = new System.Windows.Forms.TextBox();
            this.severLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftBackLabel
            // 
            this.leftBackLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.leftBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBackLabel.Location = new System.Drawing.Point(121, 118);
            this.leftBackLabel.Name = "leftBackLabel";
            this.leftBackLabel.Size = new System.Drawing.Size(697, 852);
            this.leftBackLabel.TabIndex = 0;
            // 
            // rightBackLabel
            // 
            this.rightBackLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.rightBackLabel.Location = new System.Drawing.Point(1114, 118);
            this.rightBackLabel.Name = "rightBackLabel";
            this.rightBackLabel.Size = new System.Drawing.Size(697, 852);
            this.rightBackLabel.TabIndex = 1;
            // 
            // hostLabel
            // 
            this.hostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hostLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.ForeColor = System.Drawing.Color.Black;
            this.hostLabel.Location = new System.Drawing.Point(202, 201);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(516, 146);
            this.hostLabel.TabIndex = 2;
            this.hostLabel.Text = "Create a Server";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joinLabel
            // 
            this.joinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.joinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joinLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLabel.ForeColor = System.Drawing.Color.Black;
            this.joinLabel.Location = new System.Drawing.Point(1204, 201);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(516, 146);
            this.joinLabel.TabIndex = 3;
            this.joinLabel.Text = "Join a Server";
            this.joinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.joinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.joinButton.FlatAppearance.BorderSize = 3;
            this.joinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.joinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.ForeColor = System.Drawing.Color.Black;
            this.joinButton.Location = new System.Drawing.Point(1204, 498);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(516, 385);
            this.joinButton.TabIndex = 5;
            this.joinButton.Text = "JOIN";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createButton.FlatAppearance.BorderSize = 3;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(202, 498);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(516, 385);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(911, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "OR";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Green;
            this.errorLabel.Location = new System.Drawing.Point(1344, 915);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(260, 30);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Error!  Please try again!";
            this.errorLabel.Visible = false;
            // 
            // clientInput
            // 
            this.clientInput.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInput.Location = new System.Drawing.Point(1334, 417);
            this.clientInput.Name = "clientInput";
            this.clientInput.Size = new System.Drawing.Size(270, 56);
            this.clientInput.TabIndex = 10;
            // 
            // serverInput
            // 
            this.serverInput.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInput.Location = new System.Drawing.Point(320, 417);
            this.serverInput.Name = "serverInput";
            this.serverInput.Size = new System.Drawing.Size(270, 56);
            this.serverInput.TabIndex = 11;
            // 
            // severLabel
            // 
            this.severLabel.AutoSize = true;
            this.severLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.severLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severLabel.Location = new System.Drawing.Point(347, 370);
            this.severLabel.Name = "severLabel";
            this.severLabel.Size = new System.Drawing.Size(214, 29);
            this.severLabel.TabIndex = 12;
            this.severLabel.Text = "Enter your username";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clientLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.Location = new System.Drawing.Point(1366, 370);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(214, 29);
            this.clientLabel.TabIndex = 13;
            this.clientLabel.Text = "Enter your username";
            // 
            // ServerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.severLabel);
            this.Controls.Add(this.serverInput);
            this.Controls.Add(this.clientInput);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.rightBackLabel);
            this.Controls.Add(this.leftBackLabel);
            this.Name = "ServerScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftBackLabel;
        private System.Windows.Forms.Label rightBackLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox clientInput;
        private System.Windows.Forms.TextBox serverInput;
        private System.Windows.Forms.Label severLabel;
        private System.Windows.Forms.Label clientLabel;
    }
}
