using System;

class Program
{
    static void Main()
    {
        string sentence = "this is a test and this test is fun";

        DuplicateWords(sentence);
    }

    static void DuplicateWords(string sentence)
    {
        string[] words = sentence.Split(' ');

        bool[] visited= new bool[words.Length];

        Console.WriteLine("Duplicate Words:");

        for (int i=0;i<words.Length;i++)
        {
            if (visited[i]) continue;

            int count = 0;

            for (int  j=0;j<words.Length;j++)
            {
                if (words[i] == words[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            if (count > 1)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}