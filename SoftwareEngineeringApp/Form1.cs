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
            this.highscores = Quiz.highscores;

            Quiz.questionsLvl1.Add(new Question("How are you", "good", "very good", "excellent", "dying inside because you dont understand how to do this", 'D'));

            ReadHighScoresFromFile(); //needs implementation
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
            usernameLabel.Hide();
            usernameTextBox.Hide();
            usernameButton.Hide();
            easyRadio.Hide();
            mediumRadio.Hide();
            hardRadio.Hide();
            diffLabel.Hide();
            


            //displays all scores in the highscores dictionary sorted from highest to lowest (to be added, below is the link). 
            //The link to the the source of the solution:
            //https://www.c-sharpcorner.com/UploadFile/mahesh/sort-a-dictionary-by-value-in-C-Sharp/
            foreach (var usernameHighscore in highscores)  
            {
                highScores_listBox.Items.Add(usernameHighscore.Key + "\t" + usernameHighscore.Value);
            }
            highScores_listBox.Show();
            play_button.Show();
            
        }

        private void ReadHighScoresFromFile()
        {
            //this will read highscores from either .txt or .dat file and put them in the highscores directory
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var m = new helpScreen();
            m.Show();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        }
    }
}
