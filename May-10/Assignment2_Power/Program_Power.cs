using ConsoleApp1;

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Math_Operation calc = new Math_Operation();
        Console.WriteLine("Exponential is: ");
        Console.WriteLine("2 ^ 3 = " + calc.Power(2, 3));
        Console.WriteLine("5.5. ^ 2 = " + calc.Power(5.5, 2));
    }
}