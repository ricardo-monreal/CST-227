using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class GameGrid : Form
    {
        // initialize difficulty variable
        public int difficulty;
        public GameGrid(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }



        private void GameGrid_Load(object sender, EventArgs e)
        {
            // auto-resize based on number of cells created by difficulty
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // set difficulty based on passed difficulty
            // easy 1, medium 2, hard 3
            int size = difficulty * 8;

            // create 2d grid 
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    // create a button based on gameCell
                    gameCell cellButton = new gameCell();
                    // size of each game cell in pixels
                    int x = column * 35;
                    int y = row * 35;
                    cellButton.Location = new System.Drawing.Point(x, y);
                    cellButton.Size = new System.Drawing.Size(35, 35);
                    this.Controls.Add(cellButton);
                }
            }
        }

    }
}
