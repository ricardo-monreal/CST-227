using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour
{
    class Program
    {

        static int BoardSize = 8;

        static int attemptedMoves = 0;

        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };


        static int[,] boardGrid = new int[BoardSize, BoardSize];

        // driver code
        static void Main(string[] args)
        {
            solveKT();
            Console.ReadLine();

        }

        static void solveKT()
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    boardGrid[x, y] = -1;
                }
            }

            int startX = 0;
            int startY = 4;

            boardGrid[startX, startY] = 0;

            attemptedMoves = 0;

            if (!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}", startX, startY);
            }
            else
            {
                printSolution(boardGrid);
                Console.WriteLine("Total attempted moves {0}", attemptedMoves);
            }
        }


        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0)
            {
                Console.WriteLine("Attempts: {0}", attemptedMoves);
            } 
           

            int k, next_x, next_y;

            if (moveCount == BoardSize * BoardSize)
            {
                return true;
            }
            //compare all of the knight's possible moves
            int next = CountVisitedNeighbors(x, y);
            next_x = x + xMove[next];
            next_y = y + yMove[next];
            boardGrid[next_x, next_y] = moveCount;
            if (solveKTUtil(next_x, next_y, moveCount + 1))
                return true;
            else
                // backtracking
                boardGrid[next_x, next_y] = -1;
            return false;
            //for (k = 0; k < 8; k++)
            //{
            //    next_x = x + xMove[k];
            //    next_y = y + yMove[k];
            //    if (isSquareSafe(next_x, next_y))
            //    {
            //        boardGrid[next_x, next_y] = moveCount;
            //        if (solveKTUtil(next_x, next_y, moveCount + 1))
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            boardGrid[next_x, next_y] = -1;
            //        }
            //    }
            //}
            return false;
        }

        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < BoardSize &&
                y >= 0 && y < BoardSize &&
                boardGrid[x, y] == -1);
        }

        static void printSolution(int[,] solution)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Console.WriteLine($"Square {solution[x, y]} has been marked as visited");
                }
                
            }
            Console.WriteLine();
        }

        static int GetEmptyAdjacent(int x, int y)
        {
            int allAdjacent = 0;
            for (int i = 0; i < 8; i++)
            {
                if (isSquareSafe(x + xMove[i], y + yMove[i])) allAdjacent++;
            }
            return allAdjacent;
        }

        /*You will have to create a function named something like "int CountVisitedNeighbors()". Use this function to compare all of the knight's possible moves. Choose the next move where the most neighbors have already been visited.*/
        static int CountVisitedNeighbors(int x, int y)
        {
            int minDegree = 9, minDegreeIdx = -1, tmp, nx, ny;

            // iterate through possible neighbors
            for (int k = 0; k < 8; k++)
            {
                nx = x + xMove[k];
                ny = y + yMove[k];
                if (isSquareSafe(nx, ny) && (tmp = GetEmptyAdjacent(nx, ny)) < minDegree)
                {
                    minDegree = tmp;
                    minDegreeIdx = k;
                }
            }

            return minDegreeIdx;
        }
    }
}
