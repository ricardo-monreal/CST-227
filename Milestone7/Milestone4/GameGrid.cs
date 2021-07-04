using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using MinesweeperBoardModel;

namespace Milestone6
{
    public partial class GameGrid : Form
    {
        // create stopwatch
        Stopwatch stopWatch = new Stopwatch();

        public gameCell[,] cellButton;
        int size;

        // initialize difficulty variable 
        public int difficulty;
        public GameGrid(int difficulty)
        {
            InitializeComponent();
            // Set difficulty
            this.difficulty = difficulty;
        }

        private void GameGrid_Load(object sender, EventArgs e)
        {
            // start timer
            stopWatch.Start();

            // auto-resize based on number of cells created by difficulty
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // set difficulty based on passed difficulty
            size = difficulty * 8;

            // create array of game cells
            cellButton = new gameCell[size, size];

            // create 2d grid 
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    // create a button based on gameCell
                    cellButton[row, column] = new gameCell();
                    // size of each game cell in pixels
                    int x = column * 35;
                    int y = row * 35;
                    cellButton[row, column].Location = new System.Drawing.Point(x, y);
                    cellButton[row, column].Size = new System.Drawing.Size(35, 35);
                    cellButton[row, column].setRow(row);
                    cellButton[row, column].setColumn(column);
                    cellButton[row, column].createGrid(this);
                    this.Controls.Add(cellButton[row, column]);
                }
            }

            // Number of Cells
            double cellNumber = size * size;

            // createa random perctange 
            Random random = new Random();
            double randomPercent = random.Next(15, 20);

            // set number of cells to be live cells
            randomPercent = randomPercent / 100;
            double randomCount = Math.Round(cellNumber * randomPercent, 0);

            int[] randomIsLive = new int[Convert.ToInt32(randomCount)];

            // array of cells to be live cells
            for (int i = 0; i < randomCount; i++)
            {
                double cellIsLive = random.Next(0, Convert.ToInt32(cellNumber));

                int position = Array.IndexOf(randomIsLive, cellIsLive);
                if (position > -1)
                {
                    // do not add if number is present
                    return;
                }
                else
                {
                    randomIsLive[i] = Convert.ToInt32(cellIsLive);
                }
            }

            // set cells live by looping through grid
            int liveCounter = 0;
            for (int row = 0; row < cellButton.GetLength(0); row++)
            {
                for (int column = 0; column < cellButton.GetLength(0); column++)
                {
                    if (randomIsLive.Contains(liveCounter))
                    {
                        cellButton[row, column].setLive(true);
                    }
                    liveCounter++;
                }
            }

            // set neighbors count.
            int neighborsCounter = 0;
            for (int row = 0; row < cellButton.GetLength(0); row++)
            {
                for (int column = 0; column < cellButton.GetLength(0); column++)
                {
                    neighborsCounter = 0;
                    bool cellValue = cellButton[row, column].getLive();
                    if (cellValue == false)
                    {
                        // leftNeighbor
                        if (row > 0)
                        {
                            bool value = cellButton[row - 1, column].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // rightNeighbor
                        if (row < cellButton.GetLength(0) - 1)
                        {
                            bool value = cellButton[row + 1, column].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topNeighbor
                        if (column > 0)
                        {
                            bool value = cellButton[row, column - 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomNeighbor
                        if (column < cellButton.GetLength(0) - 1)
                        {
                            bool value = cellButton[row, column + 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topLeftNeighbor
                        if ((row > 0) && (column > 0))
                        {
                            bool value = cellButton[row - 1, column - 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topRightNeighbor
                        if ((row < cellButton.GetLength(0) - 1) && (column > 0))
                        {
                            bool value = cellButton[row + 1, column - 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomLeftNeighbor
                        if ((row > 0) && (column < cellButton.GetLength(0) - 1))
                        {
                            bool value = cellButton[row - 1, column + 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomRightNeighbor
                        if ((row < cellButton.GetLength(0) - 1) && (column < cellButton.GetLength(0) - 1))
                        {
                            bool value = cellButton[row + 1, column + 1].getLive();
                            if (value)
                            {
                                neighborsCounter++;
                            }
                        }
                        // setNeighbors
                        cellButton[row, column].setNeighbors(neighborsCounter);
                    }
                    else
                    {
                        // if live setNeighbors to 9 
                        cellButton[row, column].setNeighbors(9);
                    }
                }
            }
            
        }

        public virtual void calculateLiveNeighbors()
        {

            // For each Cell in the game grid
            for (int i = 0; i < cellButton.GetLength(0); i++)
            {
                // Create counter 
                int counter = 0;
                for (int j = 0; j < cellButton.GetLength(0); j++)
                {
                    if (counter < cellButton.GetLength(0))
                    {
                        bool val = cellButton[i, j].getLive();
                        if (val)
                        {
                            cellButton[i, j].revealLive();
                        }
                        else
                        {
                            cellButton[i, j].showNeighbors();
                        }

                    }
                }
            }
        }

        // milestone 3 setup recursion
        public void floodFill(int i, int j)
        {

            bool cellVal = cellButton[i, j].getLive();
            if (cellVal == false)
            {
                // will check neighbors to the LEFT
                if (i > 0)
                {
                    // Get Neighbors
                    double val = cellButton[i - 1, j].getNeighbors();
                    bool visited = cellButton[i - 1, j].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        cellButton[i - 1, j].setVisited(true);
                        cellButton[i - 1, j].showNeighbors();
                        floodFill(i - 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i - 1, j].setVisited(true);
                        cellButton[i - 1, j].showNeighbors();
                    }
                }

                // will check neighbors to the RIGHt
                if (i < cellButton.GetLength(0) - 1)
                {
                    // Get Neighbors
                    double val = cellButton[i + 1, j].getNeighbors();
                    bool visited = cellButton[i + 1, j].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        cellButton[i + 1, j].setVisited(true);
                        cellButton[i + 1, j].showNeighbors();
                        floodFill(i + 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i + 1, j].setVisited(true);
                        cellButton[i + 1, j].showNeighbors();
                    }
                }

                // will check neighbors to the TOP
                if (j > 0)
                {
                    // Get Neighbors
                    double val = cellButton[i, j - 1].getNeighbors();
                    bool visited = cellButton[i, j - 1].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        cellButton[i, j - 1].setVisited(true);
                        cellButton[i, j - 1].showNeighbors();
                        floodFill(i, j - 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i, j - 1].setVisited(true);
                        cellButton[i, j - 1].showNeighbors();
                    }
                }

                // will check neighbors to the BOTTOM 
                if (j < cellButton.GetLength(0) - 1)
                {
                    double val = cellButton[i, j + 1].getNeighbors();
                    bool visited = cellButton[i, j + 1].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        cellButton[i, j + 1].setVisited(true);
                        cellButton[i, j + 1].showNeighbors();
                        floodFill(i, j + 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i, j + 1].setVisited(true);
                        cellButton[i, j + 1].showNeighbors();
                    }
                }
            }
            return;
        }

        public void checkWin()
        {
            // Check if game is won
            int cellsVisited = 0;
            int visitedcounter = size * size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // if all cells are visited
                    if (cellButton[i, j].getVisited())
                    {
                        cellsVisited++;
                    }
                    // if bombs remain
                    if (cellButton[i, j].getLive())
                    {
                        cellsVisited++;
                    }
                }
            }
            // If you have won the game
            if (cellsVisited == visitedcounter)
            {
                
                stopWatch.Stop();
                
                TimeSpan ts = stopWatch.Elapsed;

                // win game display
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                string text = "You have won!" + Environment.NewLine + "Your play time was: " + elapsedTime + " seconds.";
                //MessageBox.Show(text);


                // show dialog box and capture return
                DialogResult result = MessageBox.Show(text, "", MessageBoxButtons.OK);
                // if return is ok
                if (result == DialogResult.OK)
                {
                    // bool for win or lose

                    
                    bool gameWon = true;
                    HighScore highScore = new HighScore(difficulty, ts, gameWon);
                    highScore.Show();
                }
                // if return is cancel or close
                else if (result == DialogResult.Cancel)
                {
                    // bool for win or lose
                    bool gameWon = true;
                    HighScore highScore = new HighScore(difficulty, ts, gameWon); ;
                    highScore.Show();
                }

            }
        }

    }
}
