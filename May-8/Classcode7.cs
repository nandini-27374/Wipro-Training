using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            {"Mumbai", "Maharashtra" },
            {"Bangalore", "Karnataka" },
            {"Chennai", "Tamil Nadu" },
            {"Kolkata", "West Bengal" },
            {"Andhra Pradesh", "Amaravathi" }
        };

        Console.WriteLine("Indian Cities and their States:");

        foreach (var city in cities)
        {
            Console.WriteLine($"{city.Key} is in {city.Value}");
        }

        //Check if a specific city exists
        if (cities.ContainsKey("Chennai"))
        {
            Console.WriteLine("Chennai is present in the dictionary. ");
        }
    }
}