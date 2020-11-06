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
        public Dictionary<string, int> highscores;

        public Form1()
                    {
            InitializeComponent();
            //highscores.Add("david", 0); // line for testing

            
            Quiz.LoadHighScoresFromFile();
            Quiz.LoadQuestionsFromFile();

            this.highscores = Quiz.highscores;

            DisplayHighScores();
        }
            Quiz.questionsLvl1.Add(new Question("How are you", "good", "very good", "excellent", "dying inside because you dont understand how to do this", 'D'));

        public Form1(bool fromQuestionScreen)
        {
            InitializeComponent();
            this.highscores = Quiz.highscores;
            ContinueToMainWindow();
        }

        public static int gameDiff = 0;
        public void usernameButton_Click(object sender, EventArgs e)
        {
            string usernameEntered = usernameTextBox.Text;
            if ((AddUsernameToDictionary(usernameEntered)) & (easyRadio.Checked))
            {
                gameDiff = (gameDiff + 1);
                Application.Run(new QuestionScreen());
            }

            else if ((AddUsernameToDictionary(usernameEntered)) & (mediumRadio.Checked))
            {
                gameDiff = (gameDiff + 2);
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


            else if ((AddUsernameToDictionary(usernameEntered)) & (hardRadio.Checked))
            {
                gameDiff = (gameDiff + 3);
                ContinueToMainWindow();
            }
            QuestionScreen form = new QuestionScreen();
            
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
            easyRadio.Hide();
            mediumRadio.Hide();
            hardRadio.Hide();
            diffLabel.Hide();
            


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
            this.Visible = false;
            this.Hide();
            QuestionScreen qs = new QuestionScreen();
                        qs.ShowDialog();
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void highScores_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mediumRadio_CheckedChanged(object sender, EventArgs e)
        {

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
