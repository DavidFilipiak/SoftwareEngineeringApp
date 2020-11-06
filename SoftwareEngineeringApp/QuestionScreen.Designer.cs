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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionA_button
            // 
            this.optionA_button.Location = new System.Drawing.Point(18, 160);
            this.optionA_button.Margin = new System.Windows.Forms.Padding(2);
            this.optionA_button.Name = "optionA_button";
            this.optionA_button.Size = new System.Drawing.Size(172, 81);
            this.optionA_button.TabIndex = 0;
            this.optionA_button.Text = "button1";
            this.optionA_button.UseVisualStyleBackColor = true;
            this.optionA_button.Click += new System.EventHandler(this.optionA_button_Click);
            // 
            // optionB_button
            // 
            this.optionB_button.Location = new System.Drawing.Point(354, 155);
            this.optionB_button.Margin = new System.Windows.Forms.Padding(2);
            this.optionB_button.Name = "optionB_button";
            this.optionB_button.Size = new System.Drawing.Size(172, 91);
            this.optionB_button.TabIndex = 1;
            this.optionB_button.Text = "button2";
            this.optionB_button.UseVisualStyleBackColor = true;
            this.optionB_button.Click += new System.EventHandler(this.optionB_button_Click);
            // 
            // optionC_button
            // 
            this.optionC_button.Location = new System.Drawing.Point(18, 262);
            this.optionC_button.Margin = new System.Windows.Forms.Padding(2);
            this.optionC_button.Name = "optionC_button";
            this.optionC_button.Size = new System.Drawing.Size(177, 81);
            this.optionC_button.TabIndex = 2;
            this.optionC_button.Text = "button3";
            this.optionC_button.UseVisualStyleBackColor = true;
            this.optionC_button.Click += new System.EventHandler(this.optionC_button_Click);
            // 
            // optionD_button
            // 
            this.optionD_button.Location = new System.Drawing.Point(354, 262);
            this.optionD_button.Margin = new System.Windows.Forms.Padding(2);
            this.optionD_button.Name = "optionD_button";
            this.optionD_button.Size = new System.Drawing.Size(177, 84);
            this.optionD_button.TabIndex = 3;
            this.optionD_button.Text = "button4";
            this.optionD_button.UseVisualStyleBackColor = true;
            this.optionD_button.Click += new System.EventHandler(this.optionD_button_Click);
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(260, 95);
            this.question_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(35, 13);
            this.question_label.TabIndex = 4;
            this.question_label.Text = "label1";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(559, 11);
            this.timer_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(19, 13);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "20";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // questionNumber_label
            // 
            this.questionNumber_label.AutoSize = true;
            this.questionNumber_label.Location = new System.Drawing.Point(10, 11);
            this.questionNumber_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionNumber_label.Location = new System.Drawing.Point(346, 9);
            this.questionNumber_label.Name = "questionNumber_label";
            this.questionNumber_label.Size = new System.Drawing.Size(35, 13);
            this.questionNumber_label.TabIndex = 5;
            this.questionNumber_label.Text = "label1";
            this.questionNumber_label.Click += new System.EventHandler(this.questionNumber_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected difficulty";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(296, 344);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(35, 13);
            this.labelDiff.TabIndex = 8;
            this.labelDiff.Text = "label2";
            this.labelDiff.Click += new System.EventHandler(this.labelDiff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Temporary defeat option";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Location = new System.Drawing.Point(12, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(49, 17);
            this.score_label.TabIndex = 7;
            this.score_label.Text = "Score:";
            // 
            // QuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.questionNumber_label);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.optionD_button);
            this.Controls.Add(this.optionC_button);
            this.Controls.Add(this.optionB_button);
            this.Controls.Add(this.optionA_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuestionScreen";
            this.Text = "QuestionScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionScreen_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label score_label;
    }
}