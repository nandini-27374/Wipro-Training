/*

Count how many times each word appears in a sentence.
Instructions:
1. Input a sentence like: "C# is great and C# is fun"
2. Split it into words.
3. Use LINQ group by and count .
4. Print:
C#: 2
is: 2
great: 1
and: 1
fun: 1

*/

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string sentence = "C# is great and C# is fun";

        var wordCount = sentence.Split(' ').GroupBy(word => word).Select(group => new { Word = group.Key, Count = group.Count() });

        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Word}:{item.Count}");
        }
    }
}

/*

Output:

C#:2
is:2
great: 1
and: 1
fun: 1

*/