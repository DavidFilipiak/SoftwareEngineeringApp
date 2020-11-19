using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringApp
{
    public partial class QuestionScreen : Form
    {
        private int questionNumber = 1;
        private int userScore = 0;
        //private static int difficulty; //data type can be changed
        private static int time = 20;
        Question currentQuestion;
        private int gameDiff;

        private List<Question> usedQuestions = new List<Question>();
     

        public QuestionScreen(int gameDifficulty)
        {
            InitializeComponent();
            this.ActiveControl = null;
            this.gameDiff = gameDifficulty;
            DisplayGameDifficulty(gameDifficulty);
            userScore = 0;
            timer.Interval = 1000;
            ChooseQuestion(this.gameDiff, this.questionNumber);
            optionA_button.MouseEnter += OnMouseEnterButton1;
            optionA_button.MouseLeave += OnMouseLeaveButton1;
            optionB_button.MouseEnter += OnMouseEnterButton2;
            optionB_button.MouseLeave += OnMouseLeaveButton2;
            optionC_button.MouseEnter += OnMouseEnterButton3;
            optionC_button.MouseLeave += OnMouseLeaveButton3;
            optionD_button.MouseEnter += OnMouseEnterButton4;
            optionD_button.MouseLeave += OnMouseLeaveButton4;
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

            questionNumber_label.Text = "Question " + questionNumber.ToString();
            question_label.Text = currentQuestion.QuestionWording;
            optionA_button.Text = currentQuestion.Options[0];
            optionB_button.Text = currentQuestion.Options[1];
            optionC_button.Text = currentQuestion.Options[2];
            optionD_button.Text = currentQuestion.Options[3];

            score_label.Text = "Score: " + userScore.ToString();
        }

        private Question GetRandomQuestion(List<Question> questionList)
        {
            Random random = new Random();
            int randomPos;
            Question selectedQuestion;
            do
            {
                randomPos = random.Next(0, questionList.Count);
                selectedQuestion = questionList[randomPos];
            }
            while (this.usedQuestions.Contains(selectedQuestion) == true);

            this.usedQuestions.Add(selectedQuestion);
            return selectedQuestion;
        }

        private void ChooseQuestion(int gameDifficulty, int questionNumber)
        {
            if (questionNumber <= 20)
            {
                if (gameDifficulty == 1 && questionNumber <= 10)
                {
                    DisplayQuestion(1);
                }
                else if ((gameDifficulty == 1 && questionNumber <= 20) || (gameDifficulty == 2 && questionNumber <= 10))
                {
                    DisplayQuestion(2);
                }
                else if ((gameDifficulty == 2 && questionNumber <= 20) || (gameDifficulty == 3 && questionNumber <= 10))
                {
                    DisplayQuestion(3);
                }
                else
                {
                    DisplayQuestion(4);
                }
            }
            else
            {
                SaveScore();
                OpenMainScreen();
            }
        }

        private void SetTimer(int seconds)
        {
            time = seconds;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            optionA_button.BackColor = Color.LightSeaGreen; //Changes colour of button to Light Sea Green
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            optionA_button.BackColor = SystemColors.ButtonFace; //Reverts the colour to the original grey
        }
        private void OnMouseEnterButton2(object sender, EventArgs e) //Changes colour of button to Light Sea Green
        {
            optionB_button.BackColor = Color.LightSeaGreen; ;
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e) //Reverts the colour to the original grey
        {
            optionB_button.BackColor = SystemColors.ButtonFace;
        }
        private void OnMouseEnterButton3(object sender, EventArgs e) //Changes colour of button to Light Sea Green
        {
            optionC_button.BackColor = Color.LightSeaGreen; ;
        }
        private void OnMouseLeaveButton3(object sender, EventArgs e) //Reverts the colour to the original grey
        {
            optionC_button.BackColor = SystemColors.ButtonFace;
        }
        private void OnMouseEnterButton4(object sender, EventArgs e) //Changes colour of button to Light Sea Green
        {
            optionD_button.BackColor = Color.LightSeaGreen; ;
        }
        private void OnMouseLeaveButton4(object sender, EventArgs e) //Reverts the colour to the original grey
        {
            optionD_button.BackColor = SystemColors.ButtonFace;
        }
        private void optionA_button_Click(object sender, EventArgs e)
        {
            EvaluateAnswer('A');
            this.ActiveControl = null;  //unfocuses the button
        }

        private void optionB_button_Click(object sender, EventArgs e)
        {
            EvaluateAnswer('B');
            this.ActiveControl = null;  //unfocuses the button
        }

        private void optionC_button_Click(object sender, EventArgs e)
        {
            EvaluateAnswer('C');
            this.ActiveControl = null;  //unfocuses the button
        }

        private void optionD_button_Click(object sender, EventArgs e)
        {
            EvaluateAnswer('D');
            this.ActiveControl = null;  //unfocuses the button
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
            SaveScore();
            OpenMainScreen();
        }

        private void AnsweredCorrectly()
        {
            timer.Stop();
            userScore+=5;
            questionNumber++;
            ChooseQuestion(this.gameDiff, this.questionNumber);
        }

        private void EvaluateAnswer(char answer)
        {
            if (currentQuestion.CheckAnswer(answer))
            {
                AnsweredCorrectly();
            }
            else
            {
                AnsweredIncorrectly();
            }
        }

        private void DisplayGameDifficulty(int difficulty)
        {
            string textDiff;
            if (difficulty == 1)
            {
                textDiff = "Easy";
                labelDiff.Text = "Selected difficulty: " + textDiff;
            }
            else if (difficulty == 2)
            {
                textDiff = "Medium";
                labelDiff.Text = "Selected difficulty: " + textDiff;
            }

            else if (difficulty == 3)
            {
                textDiff = "Difficult";
                labelDiff.Text = "Selected difficulty: " + textDiff;
            }
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
