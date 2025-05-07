using System;
using System.Collections;


class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList() { 4, 1, 8, 3 };
        numbers.Sort();
        Console.WriteLine("Sorted:");
        
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        
        numbers.Reverse();
        Console.WriteLine("Reversed:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}