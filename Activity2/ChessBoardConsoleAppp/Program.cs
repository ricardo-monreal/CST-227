using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessBoardConsoleAppp
{
    class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {

            // show the empty board
            printBoard(myBoard);

           
            // ask the user for input. x and y coordinates where to place a piece
            Cell currentCell = setCurrentCell();
            string chesspice = setCurrentChessPiece();
            currentCell.CurrentlyOccupied = true;

            // calculate all legal moves for that pice
            myBoard.MarkNextLegalMoves(currentCell, chesspice);

           
            // print the chess board. X is for occupied square.
            printBoard(myBoard);



            // end program with returned key
            Console.ReadLine();

        }
        // Challenge - set multiple chess pieces
        public static string setCurrentChessPiece()
        {
            string choice;
            

            do
            {
                Console.WriteLine("Please select a chess piece\n");
                Console.WriteLine("a - Knight\nb - King\nc - Rook\nd - Bishop\ne - Queen\n");
                choice = Console.ReadLine();

            } while (choice != "a" && choice != "b" && choice != "c" && choice != "d" && choice != "e");

                if (choice.ToLower() == "a")
                {
                    choice = "Knight";
                }
                else if (choice.ToLower() == "b")
                {
                    choice = "King";
                }
                else if (choice.ToLower() == "c")
                {
                    choice = "Rook";
                }
                else if (choice.ToLower() == "d")
                {
                    choice = "Bishop";
                }
                else if (choice.ToLower() == "e")
                {
                    choice = "Queen";
                }
                else
                {
                    Console.WriteLine("Please select a valid option");
                }
            return choice;


        }

       

        private static Cell setCurrentCell()
        {
            // get x and y coordinates from the user. return a cell location
            Console.WriteLine("Enter the current row number");
            int currentRow = UserIntInput();

            Console.WriteLine("Enter the current column number");
            int currentColumn = UserIntInput();

            return myBoard.theGrid[currentRow, currentColumn];

        }




        // print chess board to the console
        static void printBoard(Board myBoard)
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("x");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================================");
        }


        // error checking method
        public static int UserIntInput()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please input an integer number");
            }

            return choice;
        }
        
    }
}
