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
    public partial class Form1 : Form
    {
        Dictionary<string, int> highscores;

        public Form1()
        {
            InitializeComponent();
            //highscores.Add("david", 0); // line for testing


            Quiz.LoadHighScoresFromFile();
            Quiz.LoadQuestionsFromFile();

            this.highscores = Quiz.highscores;

            DisplayHighScores();
        }

        public Form1(bool fromQuestionScreen)
        {
            InitializeComponent();
            this.highscores = Quiz.highscores;
            ContinueToMainWindow();
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            string usernameEntered = usernameTextBox.Text;
            if (AddUsernameToDictionary(usernameEntered))
            {
                ContinueToMainWindow();
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string usernameEntered = usernameTextBox.Text;
                if (AddUsernameToDictionary(usernameEntered))
                {
                    ContinueToMainWindow();
                }
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Quiz.SaveHighscoresToFile();
        }

        private bool AddUsernameToDictionary(string username)
        {
            bool oldUser;
            oldUser = highscores.ContainsKey(username);

            //checks if the username already exists, and if yes, asks if the user wants to rewrite the existing score
            if (oldUser)
            {
                DialogResult result = MessageBox.Show("The user with entered username already exists. Continuing will overwrite the saved data.\nDo you want to continue?", "Existing User", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    highscores[username] = 0;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                highscores.Add(username, 0);
            }
            return true;
        }

        private void ContinueToMainWindow()
        {
            Quiz.currentUsername = usernameTextBox.Text;

            usernameLabel.Hide();
            usernameTextBox.Hide();
            usernameButton.Hide();

            DisplayHighScores();
            
            highScores_listBox.Show();
            play_button.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var m = new helpScreen();
            m.Show();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionScreen qs = new QuestionScreen();
            qs.ShowDialog();
            this.Close();
        }

        private void DisplayHighScores()
        {
            highScores_listBox.Items.Clear();
            //displays all scores in the highscores dictionary sorted from highest to lowest (to be added, below is the link). 
            //The link to the the source of the solution:
            //https://www.c-sharpcorner.com/UploadFile/mahesh/sort-a-dictionary-by-value-in-C-Sharp/
            foreach (var usernameHighscore in highscores.OrderByDescending(key => key.Value))
            {
                highScores_listBox.Items.Add(usernameHighscore.Key + "\t" + usernameHighscore.Value);
            }
        }
    }
}
