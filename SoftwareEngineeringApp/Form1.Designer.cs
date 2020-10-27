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
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(813, 411);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(139, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter the Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(811, 447);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(801, 487);
            this.usernameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(157, 34);
            this.usernameButton.TabIndex = 3;
            this.usernameButton.Text = "Enter the username";
            this.usernameButton.UseVisualStyleBackColor = true;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // highScores_listBox
            // 
            this.highScores_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScores_listBox.FormattingEnabled = true;
            this.highScores_listBox.ItemHeight = 16;
            this.highScores_listBox.Location = new System.Drawing.Point(1421, 198);
            this.highScores_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.highScores_listBox.Name = "highScores_listBox";
            this.highScores_listBox.Size = new System.Drawing.Size(196, 228);
            this.highScores_listBox.TabIndex = 4;
            this.highScores_listBox.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(16, 15);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(115, 34);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Need help?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(582, 374);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(120, 52);
            this.play_button.TabIndex = 6;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Visible = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwareEngineeringApp.Properties.Resources.New_Background___Title;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.highScores_listBox);
            this.Controls.Add(this.usernameButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.ListBox highScores_listBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button play_button;
    }
}

