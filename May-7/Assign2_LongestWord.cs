using System;

class Program
{
    static void Main()
    {
        string sentence = "Learning C# is really interesting";
        string[] words = sentence.Split(' ');
        string longest = words[0];

        for (int i=1;i<words.Length;i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }
        Console.WriteLine($"longest word is: {longest}");
    }
}
