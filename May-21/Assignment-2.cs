/*
Use a greedy algorithm to find the minimum number of coins needed to make a given
amount.

Instructions:
1. Available denominations: {1, 2, 5, 10, 20, 50, 100, 200, 500}
2. Input:
Amount (e.g., 880 )
3. Output:
List of coins used and total count
4. Example:
Coins used: 500, 200, 100, 50, 20, 10
Total coins: 6  
 
*/

using System;
class Program
{
    static void FindMinimumCoins(int amount)
    {
        int[] coins = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int count = 0;

        Console.Write("Coins used: ");
        for (int i = 0; i < coins.Length; i++)
        {
            while (amount >= coins[i])
            {
                Console.Write(coins[i] + " ");
                amount -= coins[i];
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total coins: " + count);
    }

    static void Main()
    {
        int amount = 880;
        FindMinimumCoins(amount);
    }
}

/*
Output:

Coins used: 500 200 100 50 20 10
Total coins: 6

 */