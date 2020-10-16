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
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            string usernameEntered = usernameTextBox.Text;
            AddUsernameToDictionary(usernameEntered);

            usernameLabel.Hide();
            usernameTextBox.Hide();
            usernameButton.Hide();

            foreach(var usernameHighscore in highscores)
            {
                highScoresListBox.Items.AddRange(new object[] { usernameHighscore.Key, usernameHighscore.Value });
            }
            highScoresListBox.Show();
        }

        private void AddUsernameToDictionary(string username)
        {
            bool oldUser;
            oldUser = highscores.ContainsKey(username);

            if (oldUser)
            {
                highscores[username] = 0;
            }
            else
            {
                highscores.Add(username, 0);
            }
        }
    }
}
