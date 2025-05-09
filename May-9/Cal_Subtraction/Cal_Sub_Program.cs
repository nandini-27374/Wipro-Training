using ConsoleApp1;

using System;

class Program
{
    static void Main()
    {
        Calculator calc=new Calculator();

        Console.WriteLine("Subtraction");
        Console.WriteLine("10-8= " + calc.Sub(10,8));
        Console.WriteLine("12.5-3.7= "+ calc.Sub(12.5,3.7));
        Console.WriteLine("100-2-3= "+calc.Sub(100,2,3));
    }
}