/*

Separate even and odd numbers from a list.
Instructions:
1. Create a List<int> with at least 10 numbers.
2. Use LINQ to filter:
One list with even numbers
One list with odd numbers
3. Print both lists.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 12, 7, 9, 4, 15, 8, 3, 10, 6, 5 };

        var even = numbers.Where(n => n % 2 == 0).ToList();
        var odd = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Even Numbers: ");

        foreach (var num in even)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nOdd Numbers");
        foreach (var num in odd)
        {
            Console.Write(num + " ");
        }
    }
}

/*

Output:

Even Numbers:
12 4 8 10 6
Odd Numbers
7 9 15 3 5

*/