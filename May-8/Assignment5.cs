using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> {5,8,3,5,10,8,2,10,3,7};

        HashSet<int> unique = new HashSet<int>(numbers);

        Console.WriteLine("Unique numbers:");

        foreach (int number in unique)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"\nTotal unique numbers: {unique.Count}");
    }
}