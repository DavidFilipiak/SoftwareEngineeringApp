using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringApp
{
    public partial class QuestionScreen : Form
    {
        private static int questionNumber = 1;
        //private static int difficulty; //data type can be changed
        private static int time = 20;
        Question currentQuestion;
     

        public QuestionScreen()
        {
            InitializeComponent();

            timer.Interval = 1000;
            DisplayQuestion(1);

        }

        private void DisplayQuestion(int difficulty)
        {
            SetTimer(20);
            timer.Start();

            currentQuestion = Quiz.questionsLvl1[0];

            questionNumber_label.Text = questionNumber.ToString();
            question_label.Text = currentQuestion.QuestionWording;
            optionA_button.Text = currentQuestion.Options[0];
            optionB_button.Text = currentQuestion.Options[1];
            optionC_button.Text = currentQuestion.Options[2];
            optionD_button.Text = currentQuestion.Options[3];
        }

        private void SetTimer(int seconds)
        {
            time = seconds;
        }

        private void optionA_button_Click(object sender, EventArgs e)
        {
            //evaluate answer
        }

        private void optionB_button_Click(object sender, EventArgs e)
        {
            //evaluate answer
        }

        private void optionC_button_Click(object sender, EventArgs e)
        {
            //evaluate answer
        }

        private void optionD_button_Click(object sender, EventArgs e)
        {
            //evaluate answer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            timer_label.Text = time.ToString();

            if(time == 0)
            {
                AnsweredIncorrectly();
            }
        }

        private void AnsweredIncorrectly()
        {
            timer.Stop();
            this.Close();
        }

        private void AnsweredCorrectly()
        {
            timer.Stop();
            DisplayQuestion(1);  //needs further implementation
        }
    }
}
