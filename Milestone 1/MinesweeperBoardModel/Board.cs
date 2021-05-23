using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperBoardModel
{
    class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid { get; set; }

        
        // Board Constructor
        public Board (int s)
        {
            // initial size of board is defined by s
            Size = s;

            // create a 2D array of type cell
            theGrid = new Cell[Size, Size];

            // fill the 2D array with new cells, each with unique x and y coordinates
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

    }
}
