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

namespace Milestone5
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

            // Loop through and set neighbors count.
            int neighborsCounter = 0;
            for (int i = 0; i < cellButton.GetLength(0); i++)
            {
                for (int j = 0; j < cellButton.GetLength(0); j++)
                {
                    neighborsCounter = 0;
                    bool cellVal = cellButton[i, j].getLive();
                    if (cellVal == false)
                    {
                        // leftNeighbor
                        if (i > 0)
                        {
                            bool val = cellButton[i - 1, j].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // rightNeighbor
                        if (i < cellButton.GetLength(0) - 1)
                        {
                            bool val = cellButton[i + 1, j].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topNeighbor
                        if (j > 0)
                        {
                            bool val = cellButton[i, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomNeighbor
                        if (j < cellButton.GetLength(0) - 1)
                        {
                            bool val = cellButton[i, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topLeftNeighbor
                        if ((i > 0) && (j > 0))
                        {
                            bool val = cellButton[i - 1, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // topRightNeighbor
                        if ((i < cellButton.GetLength(0) - 1) && (j > 0))
                        {
                            bool val = cellButton[i + 1, j - 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomLeftNeighbor
                        if ((i > 0) && (j < cellButton.GetLength(0) - 1))
                        {
                            bool val = cellButton[i - 1, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }

                        // bottomRightNeighbor
                        if ((i < cellButton.GetLength(0) - 1) && (j < cellButton.GetLength(0) - 1))
                        {
                            bool val = cellButton[i + 1, j + 1].getLive();
                            if (val)
                            {
                                neighborsCounter++;
                            }
                        }
                        // setNeighbors
                        cellButton[i, j].setNeighbors(neighborsCounter);
                    }
                    else
                    {
                        // if live setNeighbors to 9 
                        cellButton[i, j].setNeighbors(9);
                    }
                }
            }
            // Center the form on screen
            this.CenterToScreen();
        }

        public virtual void revealGrid()
        {

            // For each Cell in the Square
            for (int i = 0; i < cellButton.GetLength(0); i++)
            {
                // Create counter for number of Cells in row
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
                            cellButton[i, j].revealNeighbors();
                        }

                    }
                }
            }
        }

        // Recursive algorithm that reveals blocks of cells with no live neighbors
        public void revealZeros(int i, int j)
        {

            bool cellVal = cellButton[i, j].getLive();
            if (cellVal == false)
            {
                // leftNeighbor
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
                        cellButton[i - 1, j].revealNeighbors();
                        revealZeros(i - 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i - 1, j].setVisited(true);
                        cellButton[i - 1, j].revealNeighbors();
                    }
                }

                // rightNeighbor
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
                        cellButton[i + 1, j].revealNeighbors();
                        revealZeros(i + 1, j);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i + 1, j].setVisited(true);
                        cellButton[i + 1, j].revealNeighbors();
                    }
                }

                // topNeighbor
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
                        cellButton[i, j - 1].revealNeighbors();
                        revealZeros(i, j - 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i, j - 1].setVisited(true);
                        cellButton[i, j - 1].revealNeighbors();
                    }
                }

                // bottomNeighbor
                if (j < cellButton.GetLength(0) - 1)
                {
                    double val = cellButton[i, j + 1].getNeighbors();
                    bool visited = cellButton[i, j + 1].getVisited();

                    // if neighbor 0
                    if ((Convert.ToInt32(val) == 0) && (!visited))
                    {
                        // turn neighbor to visited
                        cellButton[i, j + 1].setVisited(true);
                        cellButton[i, j + 1].revealNeighbors();
                        revealZeros(i, j + 1);
                    }
                    else if ((Convert.ToInt32(val) < 9) && (!visited))
                    {
                        cellButton[i, j + 1].setVisited(true);
                        cellButton[i, j + 1].revealNeighbors();
                    }
                }
            }
            return;
        }

        public void checkWin()
        {
            // Check if game has been won
            int cellsVisited = 0;
            int visitedcounter = size * size;

            for (int i = 0; i < size; i++)
            {
                // Create counter for number of Cells in row
                for (int j = 0; j < size; j++)
                {
                    // Check all cells is they have been visited
                    if (cellButton[i, j].getVisited())
                    {
                        cellsVisited++;
                    }
                    // Check all cells if they are a mine
                    if (cellButton[i, j].getLive())
                    {
                        cellsVisited++;
                    }
                }
            }
            // If you have won the game
            if (cellsVisited == visitedcounter)
            {
                // stop timer
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                string text = "Congratulations, your have Won!" + Environment.NewLine + "Time elapsed: " + elapsedTime + "seconds.";
                MessageBox.Show(text);
            }
        }

    }
}
