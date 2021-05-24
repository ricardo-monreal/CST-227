using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperBoardModel
{
    public class GameBoard
    {
        public int boardSize { get; set; }
        public Cell[,] theGrid { get; set; }
        public int difficulty { get; set; }

        public GameBoard ()
        {
            // initial size of board
            setBoardSize();

            // create a 2D array of type cell
            theGrid = new Cell[boardSize, boardSize];

        }

        // method to set the size fo the board with user input
        private void setBoardSize()
        {
            boardSize = 0;
            while (boardSize < 10 || boardSize > 40)
            {

                Console.WriteLine("Enter a board size to start your game. (Between 10 and 40)");

                try
                {
                    boardSize = Convert.ToInt32(Console.ReadLine());
                    if (boardSize < 10 || boardSize > 40)
                        Console.WriteLine("\nBoard size is out of range, please enter a number between 10 and 40");

                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter a valid board size (numberic values between 10 and 40)\n");
                }
                

            }
            Console.WriteLine($"\nHere's your Board of size {boardSize}x{boardSize}, Have Fun!\n");
        }

        // create each cell,if cell is live, set the neighbor count to 9
        public void fillGameBoard()
        {
            for (int i = 0; i < theGrid.GetLength(0); i++)
            {
                for (int j = 0; j < theGrid.GetLength(1); j++)
                {
                    Cell gameCell = new Cell(i, j);
                    gameCell.isLive = DetermineIsLive();
                    if (gameCell.isLive == true)
                        gameCell.Neighbors = 9;
                    theGrid[i, j] = gameCell;
                }
            }
            DetermineLiveNeighbors();
        }

        // create random and method to set a cell to isLive
        private Random rand = new Random();
        public Boolean DetermineIsLive()
        {
            // will use later to increase difficulty
            int x = rand.Next(101);
            if (x > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // method to calculate number of live neighbors
        private void DetermineLiveNeighbors()
        {
            for (int i = 0; i < theGrid.GetLength(0); i++)
            {
                for (int j = 0; j < theGrid.GetLength(1); j++)
                {
                    int x = 0;
                   
                    x += CheckNeighbors(i - 1, j - 1);
                    x += CheckNeighbors(i - 1, j);
                    x += CheckNeighbors(i - 1, j + 1);
                    x += CheckNeighbors(i, j - 1);
                    x += CheckNeighbors(i, j + 1);
                    x += CheckNeighbors(i + 1, j - 1);
                    x += CheckNeighbors(i + 1, j);
                    x += CheckNeighbors(i + 1, j + 1);

                    theGrid[i, j].Neighbors = x;

                }
            }

        }

        
        private int CheckNeighbors(int x, int y)
        {
            if (x > -1 && y > -1)
            {
                if (x < boardSize && y < boardSize)
                {
                    if (theGrid[x, y].isLive == true)
                        return 1;
                }
            }
            return 0;
        }

        // print board to console
        public void DisplayGameBoard()
        {
            for (int i = 0; i < theGrid.GetLength(0); i++)
            {
                for (int j = 0; j < theGrid.GetLength(1); j++)
                {
                    // live cells will display with * 
                    if (theGrid[i, j].isLive)
                        Console.Write("* ");
                    else
                        Console.Write("{0} ", theGrid[i, j].Neighbors);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }



    }
}
