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
    public partial class victoryScreen : Form
    {
        public Dictionary<String, int> highScores;

        public victoryScreen()
        {
            InitializeComponent();
            highScores = Quiz.highscores;
            DisplayHighScores();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             OpenMainScreen();
           
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenMainScreen()
        {
            this.Hide();
            Form1 mainForm = new Form1(true);
            mainForm.ShowDialog();
            this.Close();
        }

        private void DisplayHighScores()
        {
            listBox2.Items.Clear();
            //displays all scores in the highscores dictionary sorted from highest to lowest (to be added, below is the link). 
            //The link to the the source of the solution:
            //https://www.c-sharpcorner.com/UploadFile/mahesh/sort-a-dictionary-by-value-in-C-Sharp/
            foreach (var usernameHighscore in highScores.OrderByDescending(key => key.Value))
            {
                listBox2.Items.Add(usernameHighscore.Key + "\t" + usernameHighscore.Value);
            }
        }


    }
}


