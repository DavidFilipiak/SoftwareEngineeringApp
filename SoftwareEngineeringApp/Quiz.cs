using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public static void LoadQuestionsFromFile()
        {

        }

    }
}
