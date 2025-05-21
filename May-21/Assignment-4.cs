/*

Solve the N-Queens problem using backtracking.

Instructions:
1. Write a method to place N queens on an N x N chessboard so that no two queens
threaten each other.
2. Input:
Integer N (e.g., 4 )
3. Output:
Print all valid board configurations
4. Example for N = 4 :
_ Q _ _
_ _ _ Q
Q _ _ _
_ _ Q _

*/


using System;

class Queens
{
    static int N = 4; 

    static void Main()
    {
        int[] board = new int[N]; 
        if (PlaceQueens(board, 0))
        {
            PrintBoard(board);
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static bool PlaceQueens(int[] board, int row)
    {
        if (row == N)
        {
            return true; 
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(board, row, col))
            {
                board[row] = col; 
                if (PlaceQueens(board, row + 1))
                {
                    return true; 
                }
               
            }
        }

        return false; 
    }

    static bool IsSafe(int[] board, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
           
            if (board[i] == col)
                return false;

            
            if (Math.Abs(board[i] - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    static void PrintBoard(int[] board)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (board[i] == j)
                    Console.Write("Q ");
                else
                    Console.Write("- ");
            }
            Console.WriteLine();
        }
    }
}

/*
Output:

-Q - -
- - -Q
Q - - -
- -Q -

*/