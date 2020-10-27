namespace SoftwareEngineeringApp
{
    partial class QuestionScreen
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
            this.components = new System.ComponentModel.Container();
            this.optionA_button = new System.Windows.Forms.Button();
            this.optionB_button = new System.Windows.Forms.Button();
            this.optionC_button = new System.Windows.Forms.Button();
            this.optionD_button = new System.Windows.Forms.Button();
            this.question_label = new System.Windows.Forms.Label();
            this.questionNumber_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // optionA_button
            // 
            this.optionA_button.Location = new System.Drawing.Point(24, 197);
            this.optionA_button.Name = "optionA_button";
            this.optionA_button.Size = new System.Drawing.Size(230, 100);
            this.optionA_button.TabIndex = 0;
            this.optionA_button.Text = "button1";
            this.optionA_button.UseVisualStyleBackColor = true;
            this.optionA_button.Click += new System.EventHandler(this.optionA_button_Click);
            // 
            // optionB_button
            // 
            this.optionB_button.Location = new System.Drawing.Point(472, 191);
            this.optionB_button.Name = "optionB_button";
            this.optionB_button.Size = new System.Drawing.Size(230, 112);
            this.optionB_button.TabIndex = 1;
            this.optionB_button.Text = "button2";
            this.optionB_button.UseVisualStyleBackColor = true;
            this.optionB_button.Click += new System.EventHandler(this.optionB_button_Click);
            // 
            // optionC_button
            // 
            this.optionC_button.Location = new System.Drawing.Point(24, 322);
            this.optionC_button.Name = "optionC_button";
            this.optionC_button.Size = new System.Drawing.Size(236, 100);
            this.optionC_button.TabIndex = 2;
            this.optionC_button.Text = "button3";
            this.optionC_button.UseVisualStyleBackColor = true;
            this.optionC_button.Click += new System.EventHandler(this.optionC_button_Click);
            // 
            // optionD_button
            // 
            this.optionD_button.Location = new System.Drawing.Point(472, 322);
            this.optionD_button.Name = "optionD_button";
            this.optionD_button.Size = new System.Drawing.Size(236, 103);
            this.optionD_button.TabIndex = 3;
            this.optionD_button.Text = "button4";
            this.optionD_button.UseVisualStyleBackColor = true;
            this.optionD_button.Click += new System.EventHandler(this.optionD_button_Click);
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(346, 117);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(46, 17);
            this.question_label.TabIndex = 4;
            this.question_label.Text = "label1";
            // 
            // questionNumber_label
            // 
            this.questionNumber_label.AutoSize = true;
            this.questionNumber_label.Location = new System.Drawing.Point(13, 13);
            this.questionNumber_label.Name = "questionNumber_label";
            this.questionNumber_label.Size = new System.Drawing.Size(46, 17);
            this.questionNumber_label.TabIndex = 5;
            this.questionNumber_label.Text = "label1";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(745, 13);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(24, 17);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "20";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // QuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.questionNumber_label);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.optionD_button);
            this.Controls.Add(this.optionC_button);
            this.Controls.Add(this.optionB_button);
            this.Controls.Add(this.optionA_button);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionScreen_FormClosing);
            this.Name = "QuestionScreen";
            this.Text = "QuestionScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionA_button;
        private System.Windows.Forms.Button optionB_button;
        private System.Windows.Forms.Button optionC_button;
        private System.Windows.Forms.Button optionD_button;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label questionNumber_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer;
    }
}