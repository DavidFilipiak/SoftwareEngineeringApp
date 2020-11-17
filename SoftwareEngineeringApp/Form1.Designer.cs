namespace SoftwareEngineeringApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameButton = new System.Windows.Forms.Button();
            this.highScores_listBox = new System.Windows.Forms.ListBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.diffLabel = new System.Windows.Forms.Label();
            this.easyRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.usernameLabel.Location = new System.Drawing.Point(780, 403);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(214, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter the Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(784, 447);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(210, 35);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // usernameButton
            // 
            this.usernameButton.BackColor = System.Drawing.SystemColors.Info;
            this.usernameButton.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.usernameButton.Location = new System.Drawing.Point(751, 610);
            this.usernameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(279, 41);
            this.usernameButton.TabIndex = 3;
            this.usernameButton.Text = "Save the name!";
            this.usernameButton.UseVisualStyleBackColor = false;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // highScores_listBox
            // 
            this.highScores_listBox.BackColor = System.Drawing.SystemColors.Info;
            this.highScores_listBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores_listBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.highScores_listBox.FormattingEnabled = true;
            this.highScores_listBox.ItemHeight = 23;
            this.highScores_listBox.Location = new System.Drawing.Point(1359, 105);
            this.highScores_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.highScores_listBox.Name = "highScores_listBox";
            this.highScores_listBox.Size = new System.Drawing.Size(296, 579);
            this.highScores_listBox.TabIndex = 4;
            this.highScores_listBox.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.helpButton.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(16, 15);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 50);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Need help?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.SystemColors.Info;
            this.play_button.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.play_button.Location = new System.Drawing.Point(784, 286);
            this.play_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(210, 115);
            this.play_button.TabIndex = 6;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Visible = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.BackColor = System.Drawing.Color.Transparent;
            this.diffLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffLabel.ForeColor = System.Drawing.Color.Yellow;
            this.diffLabel.Location = new System.Drawing.Point(770, 490);
            this.diffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(254, 23);
            this.diffLabel.TabIndex = 8;
            this.diffLabel.Text = "Please select a difficulty";
            this.diffLabel.Visible = false;
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.BackColor = System.Drawing.Color.Transparent;
            this.easyRadio.Font = new System.Drawing.Font("Lucida Bright", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyRadio.ForeColor = System.Drawing.Color.Yellow;
            this.easyRadio.Location = new System.Drawing.Point(664, 526);
            this.easyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(116, 43);
            this.easyRadio.TabIndex = 9;
            this.easyRadio.TabStop = true;
            this.easyRadio.Text = "Easy";
            this.easyRadio.UseVisualStyleBackColor = false;
            this.easyRadio.Visible = false;
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.BackColor = System.Drawing.Color.Transparent;
            this.mediumRadio.Font = new System.Drawing.Font("Lucida Bright", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadio.ForeColor = System.Drawing.Color.Yellow;
            this.mediumRadio.Location = new System.Drawing.Point(802, 526);
            this.mediumRadio.Margin = new System.Windows.Forms.Padding(4);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(177, 43);
            this.mediumRadio.TabIndex = 10;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = false;
            this.mediumRadio.Visible = false;
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.BackColor = System.Drawing.Color.Transparent;
            this.hardRadio.Font = new System.Drawing.Font("Lucida Bright", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardRadio.ForeColor = System.Drawing.Color.Yellow;
            this.hardRadio.Location = new System.Drawing.Point(1001, 526);
            this.hardRadio.Margin = new System.Windows.Forms.Padding(4);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(122, 43);
            this.hardRadio.TabIndex = 11;
            this.hardRadio.TabStop = true;
            this.hardRadio.Text = "Hard";
            this.hardRadio.UseVisualStyleBackColor = false;
            this.hardRadio.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SoftwareEngineeringApp.Properties.Resources.New_Background___Title;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.hardRadio);
            this.Controls.Add(this.mediumRadio);
            this.Controls.Add(this.easyRadio);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.highScores_listBox);
            this.Controls.Add(this.usernameButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.ListBox highScores_listBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton hardRadio;
    }
}

