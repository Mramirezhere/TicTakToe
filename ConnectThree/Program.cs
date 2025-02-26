using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main (string[] args)
    {
        //golbal variabe=les, list, arrays.
        //2d array
        int [][] threeByThreeBoard = new int [] [] 
        {
            new int [] { 0, 0, 0 },
            new int [] { 1, 1, 1 },
            new int [] { 2, 2, 2 },
        };
        
        int rows= 3;
        int columns= 3;
        
        if (winCheker(threeByThreeBoard)== 0)
        {
            Console.WriteLine("There is no winner");
        }

        else
        {
            Console.WriteLine("Winner: Player " + winCheker(threeByThreeBoard));
        }

        int winCheker(int [][] board)
        {
            return 0;
        }
        void HorizontalWinner (int [][] board)
        {
            for (int r= 0; r  < rows; r++)
            {
                for (int c= 0; c < columns; c++)
                {
                    if (board[r][c] != 0)
                    {
                        if (board[r][c] == board[r][c+1])
                        (board[r][c] == board[r][c+2])                        
                    }
                }
            }
        }
    }
}
