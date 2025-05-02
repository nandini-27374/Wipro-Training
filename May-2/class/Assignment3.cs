using System;
class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Enter number you want to print: ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Fibonacci Series: ");
        for (int i=0; i < count; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.WriteLine();
    }
}
