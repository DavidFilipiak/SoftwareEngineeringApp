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
            this.usernameLabel.Location = new System.Drawing.Point(610, 334);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter the Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(608, 363);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(103, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(usernameTextBox_KeyDown);
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(608, 521);
            this.usernameButton.Margin = new System.Windows.Forms.Padding(2);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(118, 28);
            this.usernameButton.TabIndex = 3;
            this.usernameButton.Text = "Save the name!";
            this.usernameButton.UseVisualStyleBackColor = true;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // highScores_listBox
            // 
            this.highScores_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScores_listBox.FormattingEnabled = true;
            this.highScores_listBox.Location = new System.Drawing.Point(1066, 161);
            this.highScores_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.highScores_listBox.Name = "highScores_listBox";
            this.highScores_listBox.Size = new System.Drawing.Size(148, 186);
            this.highScores_listBox.TabIndex = 4;
            this.highScores_listBox.Visible = false;
            this.highScores_listBox.SelectedIndexChanged += new System.EventHandler(this.highScores_listBox_SelectedIndexChanged);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(86, 28);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Need help?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(621, 279);
            this.play_button.Margin = new System.Windows.Forms.Padding(2);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(90, 42);
            this.play_button.TabIndex = 6;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Visible = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Location = new System.Drawing.Point(605, 399);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(120, 13);
            this.diffLabel.TabIndex = 8;
            this.diffLabel.Text = "Please select a difficulty";
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.Location = new System.Drawing.Point(539, 443);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(48, 17);
            this.easyRadio.TabIndex = 9;
            this.easyRadio.TabStop = true;
            this.easyRadio.Text = "Easy";
            this.easyRadio.UseVisualStyleBackColor = true;
            this.easyRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Location = new System.Drawing.Point(635, 443);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(62, 17);
            this.mediumRadio.TabIndex = 10;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = true;
            this.mediumRadio.CheckedChanged += new System.EventHandler(this.mediumRadio_CheckedChanged);
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Location = new System.Drawing.Point(739, 443);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(48, 17);
            this.hardRadio.TabIndex = 11;
            this.hardRadio.TabStop = true;
            this.hardRadio.Text = "Hard";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwareEngineeringApp.Properties.Resources.New_Background___Title;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

