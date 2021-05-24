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
        static void Main(string[] args)
        {
            // Initialize a game, fill and display the board.
            Console.WriteLine("#### Welcome to the CST-227 Minesweesper Game! ####\n");
            GameBoard newGame = new GameBoard();
            newGame.fillGameBoard();
            newGame.DisplayGameBoard();
        }
    }
}
