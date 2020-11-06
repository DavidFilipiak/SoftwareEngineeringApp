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
        private int userScore = 0;
        //private static int difficulty; //data type can be changed
        private static int time = 20;
        Question currentQuestion;
     

        public QuestionScreen()
        {
            InitializeComponent();
            int gameDiff = (Form1.gameDiff);
            

            
            userScore = 0;
            timer.Interval = 1000;
            DisplayQuestion(1);

        }

        private void QuestionScreen_FormClosing(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void DisplayQuestion(int difficulty)
        {
            SetTimer(20);
            timer.Start();

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

            score_label.Text = "Score: " + userScore.ToString();
        }

        private Question GetRandomQuestion(List<Question> questionList)
        {
            int gameDiff = (Form1.gameDiff);
            if (gameDiff == 1)
            {
                Random random = new Random();
                int randomPos = random.Next(0, questionList.Count);
                return questionList[randomPos];
            }
            else if (gameDiff == 2)
            {
                Random random = new Random();
                int randomPos = random.Next(0, questionList.Count);
                return questionList[randomPos];
            }
            else if (gameDiff == 3)
            {
                Random random = new Random();
                int randomPos = random.Next(0, questionList.Count);
                return questionList[randomPos];
            }

            else 
            {
                Random random = new Random();
                int randomPos = random.Next(0, questionList.Count);
                return questionList[randomPos];
            }

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
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            SaveScore();
            OpenMainScreen();
            

        }

        private void AnsweredCorrectly()
        {
            timer.Stop();
            userScore++;
            DisplayQuestion(1);  //needs further implementation
        }

        private void questionNumber_label_Click(object sender, EventArgs e)
        {

        }

        private void labelDiff_Click(object sender, EventArgs e)
        {
            string textDiff;
            int gameDiff = Form1.gameDiff;
            if (gameDiff == 1)
            {
                textDiff = "Easy";
                labelDiff.Text = textDiff;
            }
            else if (gameDiff == 2)
            {
                textDiff = "Medium";
                labelDiff.Text = textDiff;
            }

            else if (gameDiff == 3)
            {
                textDiff = "Difficult";
                labelDiff.Text = textDiff;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DefeatedScreen DefeatedScreen = new DefeatedScreen;
            


        }

        private void SaveScore()
        {
            Quiz.highscores[Quiz.currentUsername] = userScore;
        }

        private void OpenMainScreen()
        {
            this.Hide();
            Form1 mainForm = new Form1(true);
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
