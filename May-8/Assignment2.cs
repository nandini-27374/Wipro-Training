using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employees = new List<string>() { "yamuna", "bhavi", "cherry", "abhi", "adhitya" };

        employees.Remove("adhitya");

        Console.WriteLine("Employee list");

        foreach (var name in employees)
        {
            Console.WriteLine($"{name}");
        }

        if (employees.Contains("bhavi"))
        {
            Console.WriteLine("\n bhavi is in the list.");
        }
        else
        {
            Console.WriteLine("\n bhavi is not inthe list.");
        }
    }
}