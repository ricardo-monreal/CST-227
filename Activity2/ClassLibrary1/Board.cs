using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        // set the size of the board
        public int Size { get; set; }

        //2d array of type cell
        public Cell[,] theGrid { get; set; }

        // constructor
        public Board (int s)
        {
            // initial size of the board is defined by s.
            Size = s;

            // create a new 2d array of type cell.
            theGrid = new Cell[Size, Size];

            // fill the 2d array with new Cells, each with unique x and y coordinates.
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }



        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // clear all previous legal moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;

                }
                
            }



            // find all legal moves and mark the cell as legal moves
            switch (chessPiece)
            {
                case "Knight":
                    if (CheckGridSpace(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }

                    break;

                case "King":
                    if (CheckGridSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (CheckGridSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }

                    break;

                case "Rook":
                    CheckValidRookSpaces(currentCell);
                    
                    break;

                case "Bishop":
                    CheckValidBishopSpaces(currentCell);
                    break;

                case "Queen":
                    CheckValidBishopSpaces(currentCell);
                    CheckValidRookSpaces(currentCell);
                    break;

                default:
                    break;
            }
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;

        }

        

        // check if input is within the grid values
        public bool CheckGridSpace(int r, int c)
        {
            return (r < theGrid.GetLength(0) && r >= 0) && (c < theGrid.GetLength(1) && c >= 0);
        }


        public void CheckValidRookSpaces(Cell current)
        {
            int column = current.ColumnNumber;
            int row = current.RowNumber;
            //check right
            for (int i = column; i < Size; i++)
            {
                if (CheckGridSpace(row, i))
                {
                    theGrid[row, i].LegalNextMove = true;
                }
            }
            // check left
            for (int i = column; i >= 0; i--)
            {
                if (CheckGridSpace(row, i))
                {
                    theGrid[row, i].LegalNextMove = true;
                }
            }
            // check top
            for (int i = row; i >= 0; i--)
            {
                if (CheckGridSpace(row, i))
                {
                    theGrid[i, column].LegalNextMove = true;
                }
            }
            // check bottom
            for (int i = row; i < Size; i++)
            {
                if (CheckGridSpace(row, i)) theGrid[i, column].LegalNextMove = true;
            }
        }

        // check for Bishop 
        public void CheckValidBishopSpaces(Cell current)
        {
            int column = current.ColumnNumber;
            int row = current.RowNumber;

            // check top right
            for (int i = row; i >= 0; i--)
            {
                if (CheckGridSpace(i, column + (current.RowNumber -i)))
                {
                    theGrid[i, column + (current.RowNumber - i)].LegalNextMove = true;
                }
            }
            // check top left
            for (int i = row; i >= 0; i--)
            {
                if (CheckGridSpace(i, column - (current.RowNumber - i)))
                {
                    theGrid[i, column - (current.RowNumber - i)].LegalNextMove = true;
                }
            }
            // check bottom right
            for (int i = row; i < Size; i++)
            {
                if (CheckGridSpace(i, column + (current.RowNumber - i)))
                {
                    theGrid[i, column + (current.RowNumber - i)].LegalNextMove = true;
                }
            }
            // check bottom left
            for (int i = row; i < Size; i++)
            {
                if (CheckGridSpace(i, column - (current.RowNumber - i)))
                {
                    theGrid[i, column - (current.RowNumber - i)].LegalNextMove = true;
                }
            }

        }


    }
}
