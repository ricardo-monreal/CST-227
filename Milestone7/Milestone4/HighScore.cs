using Milestone6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone6
{
    public partial class HighScore : Form
    {
        public string gameDifficulty;
        public TimeSpan playerScore;
        public bool gameWon;

        public List<PlayerStats> easy = new List<PlayerStats>();
        public List<PlayerStats> medium = new List<PlayerStats>();
        public List<PlayerStats> hard = new List<PlayerStats>();


        public HighScore()
        {
            InitializeComponent();
        }

        public HighScore(int gameDifficulty, TimeSpan playerScore, bool gameWon)
        {
            if (!File.Exists("highscores.txt"))
            {
                File.Create("highscores.txt").Close();
            }
            foreach (string line in File.ReadLines("highscores.txt"))
            {
                var values = line.Split(',');
                

                if (values[1] == "easy")
                {
                    easy.Add(new PlayerStats(values[0], values[1], TimeSpan.Parse(values[2])));
                }
                else if (values[1] == "medium")
                {
                    medium.Add(new PlayerStats(values[0], values[1], TimeSpan.Parse(values[2])));
                }
                else if (values[1] == "hard")
                {
                    hard.Add(new PlayerStats(values[0], values[1], TimeSpan.Parse(values[2])));
                }
            }

            if (gameDifficulty == 1)
            {
                this.gameDifficulty = "easy";
            }
            else if (gameDifficulty == 2)
            {
                this.gameDifficulty = "medium";
            }
            else if (gameDifficulty == 3)
            {
                this.gameDifficulty = "hard";
            }

            this.playerScore = playerScore;
            this.gameWon = gameWon;
            
            InitializeComponent();
        }

        public Form1 Menu;

        public void createMenu(Form1 Menu)
        {
            Menu = Menu;
        }


        // if game is over show top scores, else show player stats entry controls
        private void HighScore_Load(object sender, EventArgs e)
        {

            if (!gameWon)
            {
                label_playerInitials.Visible = false;
                label_playerScore.Visible = false;
                label_score.Visible = false;
                button_addScore.Visible = false;
                textBox_initials.Visible = false;
            }
            else
            {
                label_playerInitials.Visible = true;
                label_playerScore.Visible = true;
                label_score.Visible = true;
                button_addScore.Visible = true;
                textBox_initials.Visible = true;

                label_playerScore.Text = String.Format("{0:00}:{1:00}:{2:00}", playerScore.Hours, playerScore.Minutes, playerScore.Seconds);

            }

            string output = "Difficulty: " + gameDifficulty + Environment.NewLine + Environment.NewLine;

            if (gameDifficulty == "easy")
            {
               

                foreach (var stat in easy)
                {
                    
                    output += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;
                }
                

            }

            else if (gameDifficulty == "medium")
            {
                foreach (var stat in easy)
                {
                    output += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;
                }
            }
            else if (gameDifficulty == "hard")
            {
                foreach (var stat in easy)
                {
                    output += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;
                }
            }

            label_highScores.Text = output.ToUpper();
            this.CenterToScreen();
        }


        private void button_addScore_Click(object sender, EventArgs e)
        {

            if (gameDifficulty == "easy")
            {
                easy[4] = new PlayerStats(textBox_initials.Text, gameDifficulty, playerScore);

                var newList = easy.OrderByDescending(PlayerStats => PlayerStats.playTime).ToList();
                for (int i = 0; i >= 4; i++)
                {

                    easy[i] = newList[i];
                    var sortedList = newList.OrderBy( s => s.playTime);
                }
            }
            else if (gameDifficulty == "medium")
            {
                medium[4] = new PlayerStats(textBox_initials.Text, gameDifficulty, playerScore);

                var newList = medium.OrderByDescending(PlayerStats => PlayerStats.playTime).ToList();
                for (int i = 0; i >= 4; i++)
                {
                    medium[i] = newList[i];
                }
            }
            else if (gameDifficulty == "hard")
            {
                hard[4] = new PlayerStats(textBox_initials.Text, gameDifficulty, playerScore);

                var newList = hard.OrderByDescending(PlayerStats => PlayerStats.playTime).ToList();
                for (int i = 0; i >= 4; i++)
                {
                    hard[i] = newList[i];
                }
            }


            if (!File.Exists("highscores.txt"))
            {
                File.Create("highscores.txt").Close();
            }

            string delimiter = ",";
            List<string[]> output = new List<string[]>();

            for (var i = 0; i < 5; i++)
            {
                output.Add(new string[] { easy[i].playerInitials, easy[i].gameDifficulty, easy[i].playTime.ToString() });
            }
            for (var i = 0; i < 5; i++)
            { 
                output.Add(new string[] { medium[i].playerInitials, medium[i].gameDifficulty, medium[i].playTime.ToString() });
            }
            for (var i = 0; i < 5; i++)
            {
                output.Add(new string[] { hard[i].playerInitials, hard[i].gameDifficulty, hard[i].playTime.ToString() });
            }

            int length = output.Count;

            using (System.IO.TextWriter writer = File.CreateText("highscores.txt"))
            {
                for (int index = 0; index < length; index++)
                {
                    writer.WriteLine(string.Join(delimiter, output[index]));
                }
            }

            // On win or lose show the top five scores for that difficulty
            string newScore = "Difficulty: " + gameDifficulty + Environment.NewLine + Environment.NewLine;

            if (gameDifficulty == "easy")
            {
                foreach (var stat in easy)
                {
                    newScore += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;

                }

                
            }
            else if (gameDifficulty == "medium")
            {
                foreach (var stat in medium)
                {
                    newScore += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;
                }
                
            }
            else if (gameDifficulty == "hard")
            {
                foreach (var stat in hard)
                {
                    newScore += stat.playerInitials + ": " + stat.playTime + Environment.NewLine + Environment.NewLine;
                }

            }

            label_highScores.Text = newScore.ToUpper();

            label_playerInitials.Visible = false;
            label_playerScore.Visible = false;
            label_score.Visible = false;
            button_addScore.Visible = false;
            textBox_initials.Visible = false;


        }


    }








    //private void label_topFive_Click(object sender, EventArgs e)
    //{

    //}

    //private void label1_Click(object sender, EventArgs e)
    //{

    //}

       
    
}
