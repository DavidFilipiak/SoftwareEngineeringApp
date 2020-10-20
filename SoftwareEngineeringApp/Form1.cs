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
        Dictionary<string, int> highscores = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            highscores.Add("david", 0);

            ReadHighScoresFromFile(); //needs implementation
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            string usernameEntered = usernameTextBox.Text;
            if (AddUsernameToDictionary(usernameEntered))
            {
                ContinueToMainWindow();
            }
        }

        private bool AddUsernameToDictionary(string username)
        {
            bool oldUser;
            oldUser = highscores.ContainsKey(username);

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

            foreach (var usernameHighscore in highscores)
            {
                highScores_listBox.Items.Add(usernameHighscore.Key + "\t" + usernameHighscore.Value);
            }
            highScores_listBox.Show();
        }

        private void ReadHighScoresFromFile()
        {
            //this will read highscores from either .txt or .dat file and put them in the highscores directory
        }
    }
}
