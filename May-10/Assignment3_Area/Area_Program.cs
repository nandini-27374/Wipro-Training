using ConsoleApp1;

using System;
using System.Numerics;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        Shape shape = new Shape();

        double rectArea = shape.Area(10.2, 5.3);
        double cirArea = shape.Area(7.4);
        double triangleArea = shape.Area(6.3, 4.0,true);

        Console.WriteLine("Area of Rectangle: " + rectArea);
        Console.WriteLine("Area of Circle: " + cirArea);
        Console.WriteLine("Area of Triangle: " + triangleArea);
    }
}