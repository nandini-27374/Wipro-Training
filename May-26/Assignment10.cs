/*

10. LINQ + Dictionaries – Word Frequency Analyzer
Task:
Take a paragraph as string input.
Break into words using .Split() .
Use Dictionary<string, int> to count frequencies.
Sort and display top 5 most frequent words using LINQ.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string paragraph = "Supreme value of youth period is incalculable and indescribable.Youth life is the most precious life.Youth is thebest time.The way in which you utilize this period will decide the nature of coming years thatlie ahead of you";

        var words = paragraph.ToLower().Split(new[] { ' ', '.', ',', ';', ':', '!', '?', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        var wordCounts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCounts.ContainsKey(word))
                wordCounts[word]++;
            else
                wordCounts[word] = 1;
        }

        var topWords = wordCounts.OrderByDescending(kvp => kvp.Value).Take(5);

        Console.WriteLine("Top 5 most frequent words:");

        foreach (var kvp in topWords)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

/*

Output:

Top 5 most frequent words:
of: 3
youth: 3
is: 3
the: 3
period: 2

*/