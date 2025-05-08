using System;

using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();

        numbers.Add(10);
        numbers.Add(2);
        numbers.Add(33);
        numbers.Add(40);
        numbers.Add(13);
        numbers.Add(45);
        numbers.Add(6);
        numbers.Add(20);
        numbers.Add(3);
        numbers.Add(15);

        numbers.Sort();

        Console.WriteLine("Sorted numbers");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        int min = (int)numbers[0];
        int max = (int)numbers[numbers.Count - 1];

        Console.WriteLine($"\nMinimum value:{min}");
        Console.WriteLine($"\nMaximum value:{max}");

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"Average: {average:F2}");
    }
}