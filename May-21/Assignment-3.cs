/*

Find the first non-repeating character in a string using hashing.
Instructions:
1. Input:
A string (e.g., "swiss" )
2. Output:
The first character that appears only once (e.g., 'w' )
3. Hint:
Use a Dictionary<char, int> to count frequencies
Loop again to find the first char with frequency 1

*/

using System;
using System.Collections.Generic;

class Program
{
    static char FirstNonRepeatingChar(string input)
    {
        var charcount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charcount.ContainsKey(c))
                charcount[c]++;
            else
                charcount[c]= 1;
        }

        foreach (char c in input)
        {
            if (charcount[c] == 1)
                return c;
        }
        return '$';
    }

    static void Main()
    {
        string input = "nandini";
        char result = FirstNonRepeatingChar(input);
        Console.WriteLine("The first character that appears only once is: " + result);
    }
}

/*
Output:

The first character that appears only once is: a

*/