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
            this.highScoresListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(290, 224);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(139, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter the Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(293, 256);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(293, 284);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(136, 34);
            this.usernameButton.TabIndex = 3;
            this.usernameButton.Text = "button1";
            this.usernameButton.UseVisualStyleBackColor = true;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // highScoresListBox
            // 
            this.highScoresListBox.FormattingEnabled = true;
            this.highScoresListBox.ItemHeight = 16;
            this.highScoresListBox.Location = new System.Drawing.Point(629, 27);
            this.highScoresListBox.MultiColumn = true;
            this.highScoresListBox.Name = "highScoresListBox";
            this.highScoresListBox.Size = new System.Drawing.Size(146, 244);
            this.highScoresListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highScoresListBox);
            this.Controls.Add(this.usernameButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.ListBox highScoresListBox;
    }
}

