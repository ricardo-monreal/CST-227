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

        public GameBoard()
        {
            // initial size of board
            boardSize = 1;

            // set game difficulty
            difficulty = 20;
            // create a 2D array of type cell
            theGrid = new Cell[boardSize, boardSize];

        }


        public GameBoard(int size)
        {
            boardSize = size;
            difficulty = 20;
            theGrid = new Cell[boardSize, boardSize];
            SetupLiveNeighbors();
        }


        public void SetupLiveNeighbors()
        {
            int gridSpace = (int)Math.Pow(boardSize, 2);
            int bombTotal = (int)Math.Ceiling((decimal)gridSpace * ((decimal)difficulty / 100));

            Random rand = new Random();

            bool[] liveCells = new bool[gridSpace];

            Double[] sortOrder = new double[gridSpace];

            for (int i = 0; i < sortOrder.Length; i++)
            {
                sortOrder[i] = rand.NextDouble();
            }
            for (int i = 0; i < gridSpace; i++)
            {
                liveCells[i] = i < bombTotal;
            }


            Array.Sort(sortOrder, liveCells);


            int liveCellSeed = 0;

            for (int row = 0; row < theGrid.GetLength(0); row++)
            {
                for (int column = 0; column < theGrid.GetLength(1); column++)
                {
                    theGrid[row, column] = new Cell(column, row, false, liveCells[liveCellSeed], 0);
                    liveCellSeed++;
                }
            }

            CalculateLiveNeighbors();
        }

        public void CalculateLiveNeighbors()
        {
            for (int row = 0; row < theGrid.GetLength(0); row++)
            {
                for (int column = 0; column < theGrid.GetLength(1); column++)
                {
                    CalculateLiveCellNeighbors(theGrid[row, column]);
                }
            }
        }


        private void CalculateLiveCellNeighbors(Cell c)
        {
            if (c.isLive)
            {
                c.LiveNeighbors = 9;
                return;
            }

            Cell def = new Cell(0, 0, false, false, 0);
            Cell left = (c.ColumnNumber - 1 >= 0) ? theGrid[c.RowNumber, c.ColumnNumber - 1] : def;
            Cell right = (c.ColumnNumber + 1 < boardSize) ? theGrid[c.RowNumber, c.ColumnNumber + 1] : def;
            Cell top = (c.RowNumber - 1 >= 0) ? theGrid[c.RowNumber - 1, c.ColumnNumber] : def;
            Cell bottom = (c.RowNumber + 1 < boardSize) ? theGrid[c.RowNumber + 1, c.ColumnNumber] : def;
            Cell topRight = (c.RowNumber - 1 >= 0 && c.ColumnNumber + 1 < boardSize) ? theGrid[c.RowNumber - 1, c.ColumnNumber + 1] : def;
            Cell topLeft = (c.RowNumber - 1 >= 0 && c.ColumnNumber - 1 >= 0) ? theGrid[c.RowNumber - 1, c.ColumnNumber - 1] : def;
            Cell bottomRight = (c.RowNumber + 1 < boardSize && c.ColumnNumber + 1 < boardSize) ? theGrid[c.RowNumber + 1, c.ColumnNumber + 1] : def;
            Cell bottomLeft = (c.RowNumber + 1 < boardSize && c.ColumnNumber - 1 >= 0) ? theGrid[c.RowNumber + 1, c.ColumnNumber - 1] : def;

            int liveNeighbors = 0;

            foreach (Cell neighbor in new Cell[] { left, right, top, bottom, topRight, topLeft, bottomRight, bottomLeft })
            {
                liveNeighbors += neighbor.isLive ? 1 : 0;
            }
            c.LiveNeighbors = liveNeighbors;
        }

    }
}
