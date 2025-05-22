
/*

Filter names that start with a vowel.
Instructions:
1. Create a List<string> with 8–10 names.
2. Use LINQ to find names starting with vowels (A, E, I, O, U).
3. Print the result.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var names = new List<string>
        {
            "Bhavya","Yamuna","Abhi","Eswer","Indhu","uma"
        };

        var vowels = "aeiouAEIOU";


        var filteredNames = names.Where(name => !string.IsNullOrEmpty(name) && vowels.Contains(name[0])).ToList();

        Console.WriteLine("Names starting with a vowel:");
        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}

/*

Output:

Names starting with a vowel:
Abhi
Eswer
Indhu
uma

*/