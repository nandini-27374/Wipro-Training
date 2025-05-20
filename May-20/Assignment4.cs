using System;

class Program
{
    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (str1[i] == str2[j])
                    dp[i + 1, j + 1] = dp[i, j] + 1;

                else
                    dp[i+1,j+1] = Math.Max(dp[i + 1, j], dp[i,j+1]);
            }
        }

        string lcs = "";
        int x = m, y = n;

        while (x>0 && y>0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                lcs = str1[x - 1] + lcs;
                x--; y--;
            }
            else if (dp[x - 1, y] > dp[x, y - 1])
                x--;
            else
                y--;
        }

        Console.WriteLine("LCS: " + lcs);
        Console.WriteLine("Length: " + lcs.Length);
    }
}

/*

Output:
LCS: ADH
Length: 3

*/