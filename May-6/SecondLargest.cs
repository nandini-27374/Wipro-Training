using System;
class program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 5, 60 };
        Array.Sort(numbers);
        int n = numbers.Length;
        int largest = numbers[n - 1];

        for (int i=n-2;i>=0;i--)
        {
            if (numbers[i] != largest)
            {
                Console.WriteLine(numbers[i]);
                return;
            }
        }
    }
}