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
        private static int difficulty; //data type can be changed
        Question currentQuestion;
     

        public QuestionScreen()
        {
            InitializeComponent();

            DisplayQuestion(difficulty);
        }

        private void DisplayQuestion(int difficulty)
        {
            switch(difficulty)
            {
                case 1:
                    currentQuestion = GetRandomQuestion(Quiz.questionsLvl1);
                    break;
                case 2:
                    currentQuestion = GetRandomQuestion(Quiz.questionsLvl2);
                    break;
                case 3:
                    currentQuestion = GetRandomQuestion(Quiz.questionsLvl3);
                    break;
                case 4:
                    currentQuestion = GetRandomQuestion(Quiz.questionsLvl4);
                    break;
            }

            questionNumber_label.Text = questionNumber.ToString();
            question_label.Text = currentQuestion.QuestionWording;
            optionA_button.Text = currentQuestion.Options[0];
            optionB_button.Text = currentQuestion.Options[1];
            optionC_button.Text = currentQuestion.Options[2];
            optionD_button.Text = currentQuestion.Options[3];
        }

        private Question GetRandomQuestion(List<Question> questionList)
        {
            Random random = new Random();
            int randomPos = random.Next(0, questionList.Count);
            return questionList[randomPos];
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
    }
}
