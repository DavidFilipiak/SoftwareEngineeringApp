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
            
        }
    }
}
