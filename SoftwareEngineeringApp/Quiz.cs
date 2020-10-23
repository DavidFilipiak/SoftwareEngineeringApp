using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace SoftwareEngineeringApp
{
    public static class Quiz
    {
        //Lists of questions of all levels
        public static List<Question> questionsLvl1 = new List<Question>();
        public static List<Question> questionsLvl2 = new List<Question>();
        public static List<Question> questionsLvl3 = new List<Question>();
        public static List<Question> questionsLvl4 = new List<Question>();

        public static Dictionary<string, int> highscores = new Dictionary<string, int>();
        public static string currentUsername;

        public static void LoadHighScoresFromFile()
        {
            string text = Properties.Resources.highscores;
            string[] lines = text.Split('\r');
            foreach(string line in lines)
            {
                string[] pair = line.Split(' ');
                highscores.Add(pair[0], int.Parse(pair[1]));
            }
        }

        public static void LoadQuestionsFromFile()
        {
            //code for loading

            string text = Properties.Resources.Questions; //to be uploaded
            //these data will be loaded from file;
            string[] questions = text.Split('*');
            foreach(string q in questions)
            {
                string[] partsOfQuestion = q.Split('\r');

                string difficulty = partsOfQuestion[0];
                string questionWording = partsOfQuestion[1];
                string option1 = partsOfQuestion[2];
                string option2 = partsOfQuestion[3];
                string option3 = partsOfQuestion[4];
                string option4 = partsOfQuestion[5];
                char correctAnswer = char.Parse(partsOfQuestion[6]);

                Question question = new Question(questionWording, option1, option2, option3, option4, correctAnswer);

                switch(difficulty)
                {
                    case "1":
                        questionsLvl1.Add(question);
                        break;
                    case "2":
                        questionsLvl2.Add(question);
                        break;
                    case "3":
                        questionsLvl3.Add(question);
                        break;
                    case "4":
                        questionsLvl4.Add(question);
                        break;
                    default:
                        questionsLvl1.Add(question);
                        break;
                }
            }
        }
    }
}
