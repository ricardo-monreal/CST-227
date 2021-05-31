using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinesweeperBoardModel;

namespace MinesweeperConsoleApp
{
    class Program
    {
        public static GameBoard board;
        static void Main(string[] args)
        {
            int size = -1;
            // Initialize a game, fill and display the board.
            Console.WriteLine("#### Welcome to the CST-227 Minesweesper Game! ####\n");
            //GameBoard newGame = new GameBoard();
            //newGame.CalculateLiveNeighbors();



            //newGame.DisplayGameBoard();
            while (size == -1)
            {
                Console.WriteLine("Enter the size of the Grid:");
                size = GetIntInput();
                if (size == -1)
                {
                    continue;
                }

                board = new GameBoard(size);

                //Console.Clear();
            }

            bool gameOver = false;
            PrintBoard();
            while (!gameOver)
            {
                
                Console.WriteLine("\nEnter a row number on the grid\n");
                int row = GetIntInput();
                Console.WriteLine("Enter a column number on the grid");
                int column = GetIntInput();
                // Check for invalid index values
                if (row < 0 || column < 0 || row >= size || column >= size)
                {
                    Console.WriteLine("\nYour selection is outside of the boundaries for the board created");
                    continue;
                }

                // Check if selecttion is a live bomb, end game if so
                if (board.theGrid[row, column].isLive)
                {
                    Console.Out.WriteLine("\nYou hit a bomb! Game Over!");


                    // TODO -- Prompt user to start a new game or exit
                    Console.ReadLine();
                    gameOver = true;
                    
                }
                else
                {
                    // if no live bombs selected, win game
                    if (AllSafeTilesVisited())
                    {
                        Console.WriteLine("You won! you did not landed in any bombs");
                        
                        // TODO -- Prompt user to start a new game or exit
                        Console.ReadLine();
                        gameOver = true;
                        continue;
                    }
                }
                // If no game-changing states are found, set tile to visited and continue forward
                board.theGrid[row, column].isVisited = true;

                // Print the grid
                PrintBoardDuringGame();
            }



        }


        // error checking that user inputs an integer value
        public static int GetIntInput()
        {
            int choice;
           

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Out.WriteLine("Wrong input. Please enter an integer value");
            }
           
            return choice;
        }

        // print initial board
        public static void PrintBoard()
        {
            Console.WriteLine($"A game board of size {board.boardSize}x{board.boardSize} was created, Good Luck!\n");
            int rows = board.theGrid.GetLength(0);
            int columns = board.theGrid.GetLength(1);

            // Print the top line of column headers
            for (int idx = 0; idx < columns; idx++)
            {
                if (idx == 0)
                {
                    Console.Write("");
                }
                Console.Write($" {idx}  ");
            }

            // NewLine to actual grid
            PrintLineSeparator(columns);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Print row col element
                    Console.Out.Write(": ");
                    if (board.theGrid[row, col].isVisited)
                    {
                        Console.Write(board.theGrid[row, col].LiveNeighbors);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    // If end of row, print the column number
                    if (col == columns - 1) Console.Write($": {row} ");
                }
                PrintLineSeparator(columns); // next row
            }
        }

        private static void PrintLineSeparator(int nbr)
        {
            Console.Write("\n+");
            for (int idx = 0; idx < nbr; idx++)
            {
                Console.Write("---+");
            }
            Console.Write("\n");
        }

        public static void PrintBoardDuringGame()
        {
            int rows = board.theGrid.GetLength(0);
            int columns = board.theGrid.GetLength(1);
            // Print the top line of column headers
            for (int idx = 0; idx < columns; idx++)
            {
                if (idx == 0) Console.Write("+");
                Console.Write($" {idx} +");
            }
            // NewLine to actual grid
            PrintLineSeparator(columns);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Print row col element
                    Console.Write(": ");
                    // Print row element
                    if (board.theGrid[row, col].isVisited)
                    {
                        if (board.theGrid[row, col].LiveNeighbors > 0)
                        {
                            Console.Write(board.theGrid[row, col].LiveNeighbors);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write("?");
                    }
                    Console.Write(" ");
                    // If end of row, print the column number
                    if (col == columns - 1) Console.Write($": {row} ");
                }
                PrintLineSeparator(columns); // next row
            }
        }

        public static bool AllSafeTilesVisited()
        {
            int rows = board.theGrid.GetLength(0);
            int columns = board.theGrid.GetLength(1);
            bool someUnvisited = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (!board.theGrid[row, col].isVisited && !board.theGrid[row, col].isLive) someUnvisited = true;
                }
            }
            return !someUnvisited;
        }

    }

	
}

