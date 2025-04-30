using System;

class Program
{
    static void Main()
    {
        int[] array = { 30, 2, 10, 30, 2, 18 };
        bool[] visited = new bool[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (visited[i])
                continue;

            int count = 1;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    visited[j] = true; // Mark duplicate as visited
                }
            }

            Console.WriteLine(array[i] + " occurs " + count + (count == 1 ? " time" : " times"));
        }
    }
}