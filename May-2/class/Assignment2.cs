using System;
class Program
{
    static int factorial(int number)
    {
        if (number == 0 || number ==1)
        {
            return 1;
        }
        else
        {
            return number*factorial(number-1);
        }
    }
    static void Main()
    {
        int number=int.Parse(Console.ReadLine());
        int result=factorial(number);
        Console.WriteLine($"factorial of a {number} is {result}");
    }
}
