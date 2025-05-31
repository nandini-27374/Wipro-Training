/*

5. String Analyzer Tool (LINQ + String + Dictionary)
Concepts: String manipulation, LINQ, Dictionary Task:
Accept a paragraph from user input
Count:
Word frequency
Vowel/consonant count
Longest and shortest word

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string paragraph = @"Paragraph is the group of sentences or single sentence .This Paragraph shows the definition of paragraph.";

        var words=Regex.Matches(paragraph.ToLower(),@"\b\w+\b").Cast<Match>().Select(m=>m.Value).ToList();

        var wordFrequency = words.GroupBy(w=>w).ToDictionary(g=>g.Key,g=>g.Count());

        int vowels = 0, consonants = 0;

        foreach (char c in paragraph.ToLower())
        {
            if("aeiouAEIOU".Contains(c))
                vowels++;
            else if (char.IsLetter(c)) 
                consonants++;
        }

        var longword = words.OrderByDescending(w => w.Length).FirstOrDefault();
        var shortword = words.OrderBy(w => w.Length).FirstOrDefault();

        Console.WriteLine("\nWord Frequency:");

        foreach (var pair in wordFrequency.OrderByDescending(p=>p.Value))
        {
            Console.WriteLine($"{pair.Key}:{pair.Value}");
        }

        Console.WriteLine($"\nVowels:{vowels}");
        Console.WriteLine($"Consonants:{consonants}");
        Console.WriteLine($"Longest Word:{longword}");
        Console.WriteLine($"Short Word:{shortword}");
    }
}

/*

Output:

Word Frequency:
paragraph: 3
the: 2
of: 2
is:1
group: 1
sentences: 1
or: 1
single: 1
sentence: 1
this:1
shows: 1
definition: 1

Vowels: 32
Consonants: 56
Longest Word:definition
Short Word:is

*/