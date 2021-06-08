using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperBoardModel
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public bool isVisited { get; set; }
        public bool isLive { get; set; }
        public int LiveNeighbors { get; set; }



        //constructor with default values
        public Cell()
        {
            RowNumber = -1;
            ColumnNumber = -1;
            isVisited = false;
            isLive = false;
            LiveNeighbors = 0;

            
        }

        public Cell(int column, int row, bool visited, bool live, int liveNeighbors)
        {
            ColumnNumber = column;
            RowNumber = row;
            isVisited = visited;
            isLive = live;
            LiveNeighbors = liveNeighbors;
        }


    }
}
