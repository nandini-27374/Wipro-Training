using System;
class Program
{
    static int Add(int a,int b)
    {
        return a+b;
    }
    
    static double Add(double a,double b)
    {
        return a +b;
    }
    static void Main()
    {
        Console.WriteLine("int add: " +Add(3,4));
        Console.WriteLine("DoubleAdd: " + Add(2.5,4.3));
    }
}
