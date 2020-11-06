using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringApp
{
    public class Question
    {
        private string question;
        private string[] options;
        private char correctAnswer;
        
        

        public string QuestionWording
        {
            get { return this.question; }
            set { this.question = value; }
        }

        public string[] Options
        {
            get { return this.options; }
            set { this.options = value; }
        }
        public char CorrectAnswer
        {
            get { return this.correctAnswer; }
            set { this.correctAnswer = value; }
        }

        public Question(string question, string[] options, char correctAnswer)
        {
            this.QuestionWording = question;
            this.Options = options;
            this.CorrectAnswer = correctAnswer;
        }

        public Question(string question, string option1, string option2, string option3, string option4, char correctAnswer)
        {
            this.QuestionWording = question;
            this.Options = new string[4];
            this.Options[0] = option1;
            this.Options[1] = option2;
            this.Options[2] = option3;
            this.Options[3] = option4;
            this.CorrectAnswer = correctAnswer;
        }

        public bool CheckAnswer(char givenAnswerNumber)
        {
            if (givenAnswerNumber == correctAnswer)
            {
                return true;
            }
            else return false;
        }
    }


}
