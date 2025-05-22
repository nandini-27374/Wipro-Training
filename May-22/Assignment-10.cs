/*

Identify duplicates in a list of numbers.
Instructions:
1. Create a List<int> with some repeated numbers.
2. Use LINQ to find numbers that appear more than once.
3. Print the duplicated numbers.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 1, 6, 3, 7 };

        var duplicates=numbers.GroupBy(n=>n).Where(global => global.Count() > 1).Select(global => global.Key);

        Console.WriteLine("Duplicate numbers");
        
        foreach (var num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}

/*

Output:

Duplicate numbers
1
3

*/
