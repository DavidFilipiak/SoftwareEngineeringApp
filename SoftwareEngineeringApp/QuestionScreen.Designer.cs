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
            this.timer_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.questionNumber_label = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.helplinesGroupbox = new System.Windows.Forms.GroupBox();
            this.helpNewQbutton = new System.Windows.Forms.Button();
            this.helpStopTimebutton = new System.Windows.Forms.Button();
            this.help5050button = new System.Windows.Forms.Button();
            this.helplinesGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionA_button
            // 
            this.optionA_button.Location = new System.Drawing.Point(12, 297);
            this.optionA_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionA_button.Name = "optionA_button";
            this.optionA_button.Size = new System.Drawing.Size(600, 130);
            this.optionA_button.TabIndex = 0;
            this.optionA_button.Text = "button1";
            this.optionA_button.UseVisualStyleBackColor = true;
            this.optionA_button.Click += new System.EventHandler(this.optionA_button_Click);
            // 
            // optionB_button
            // 
            this.optionB_button.Location = new System.Drawing.Point(652, 297);
            this.optionB_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionB_button.Name = "optionB_button";
            this.optionB_button.Size = new System.Drawing.Size(600, 130);
            this.optionB_button.TabIndex = 1;
            this.optionB_button.Text = "button2";
            this.optionB_button.UseVisualStyleBackColor = true;
            this.optionB_button.Click += new System.EventHandler(this.optionB_button_Click);
            // 
            // optionC_button
            // 
            this.optionC_button.Location = new System.Drawing.Point(12, 442);
            this.optionC_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionC_button.Name = "optionC_button";
            this.optionC_button.Size = new System.Drawing.Size(600, 130);
            this.optionC_button.TabIndex = 2;
            this.optionC_button.Text = "button3";
            this.optionC_button.UseVisualStyleBackColor = true;
            this.optionC_button.Click += new System.EventHandler(this.optionC_button_Click);
            // 
            // optionD_button
            // 
            this.optionD_button.Location = new System.Drawing.Point(652, 442);
            this.optionD_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionD_button.Name = "optionD_button";
            this.optionD_button.Size = new System.Drawing.Size(600, 130);
            this.optionD_button.TabIndex = 3;
            this.optionD_button.Text = "button4";
            this.optionD_button.UseVisualStyleBackColor = true;
            this.optionD_button.Click += new System.EventHandler(this.optionD_button_Click);
            // 
            // question_label
            // 
            this.question_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(588, 223);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(95, 17);
            this.question_label.TabIndex = 4;
            this.question_label.Text = "question here";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(1228, 9);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(24, 17);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "20";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Location = new System.Drawing.Point(16, 11);
            this.score_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(49, 17);
            this.score_label.TabIndex = 7;
            this.score_label.Text = "Score:";
            // 
            // questionNumber_label
            // 
            this.questionNumber_label.AutoSize = true;
            this.questionNumber_label.Location = new System.Drawing.Point(387, 9);
            this.questionNumber_label.Name = "questionNumber_label";
            this.questionNumber_label.Size = new System.Drawing.Size(114, 17);
            this.questionNumber_label.TabIndex = 5;
            this.questionNumber_label.Text = "question number";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(771, 9);
            this.labelDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(126, 17);
            this.labelDiff.TabIndex = 7;
            this.labelDiff.Text = "Selected difficulty: ";
            // 
            // helplinesGroupbox
            // 
            this.helplinesGroupbox.Controls.Add(this.helpNewQbutton);
            this.helplinesGroupbox.Controls.Add(this.helpStopTimebutton);
            this.helplinesGroupbox.Controls.Add(this.help5050button);
            this.helplinesGroupbox.Location = new System.Drawing.Point(12, 590);
            this.helplinesGroupbox.Name = "helplinesGroupbox";
            this.helplinesGroupbox.Size = new System.Drawing.Size(1240, 87);
            this.helplinesGroupbox.TabIndex = 8;
            this.helplinesGroupbox.TabStop = false;
            this.helplinesGroupbox.Text = "HELPLINES";
            // 
            // helpNewQbutton
            // 
            this.helpNewQbutton.Location = new System.Drawing.Point(969, 21);
            this.helpNewQbutton.Name = "helpNewQbutton";
            this.helpNewQbutton.Size = new System.Drawing.Size(206, 57);
            this.helpNewQbutton.TabIndex = 2;
            this.helpNewQbutton.Text = "New Question";
            this.helpNewQbutton.UseVisualStyleBackColor = true;
            // 
            // helpStopTimebutton
            // 
            this.helpStopTimebutton.Location = new System.Drawing.Point(499, 21);
            this.helpStopTimebutton.Name = "helpStopTimebutton";
            this.helpStopTimebutton.Size = new System.Drawing.Size(220, 57);
            this.helpStopTimebutton.TabIndex = 1;
            this.helpStopTimebutton.Text = "Stop Timer";
            this.helpStopTimebutton.UseVisualStyleBackColor = true;
            this.helpStopTimebutton.Click += new System.EventHandler(this.helpStopTimebutton_Click);
            // 
            // help5050button
            // 
            this.help5050button.Location = new System.Drawing.Point(77, 21);
            this.help5050button.Name = "help5050button";
            this.help5050button.Size = new System.Drawing.Size(200, 58);
            this.help5050button.TabIndex = 0;
            this.help5050button.Text = "50 / 50";
            this.help5050button.UseVisualStyleBackColor = true;
            this.help5050button.Click += new System.EventHandler(this.help5050button_Click);
            // 
            // QuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.helplinesGroupbox);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.questionNumber_label);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.optionD_button);
            this.Controls.Add(this.optionC_button);
            this.Controls.Add(this.optionB_button);
            this.Controls.Add(this.optionA_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionScreen";
            this.Text = "QuestionScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionScreen_FormClosing);
            this.helplinesGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionA_button;
        private System.Windows.Forms.Button optionB_button;
        private System.Windows.Forms.Button optionC_button;
        private System.Windows.Forms.Button optionD_button;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label questionNumber_label;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.GroupBox helplinesGroupbox;
        private System.Windows.Forms.Button helpNewQbutton;
        private System.Windows.Forms.Button helpStopTimebutton;
        private System.Windows.Forms.Button help5050button;
    }
}