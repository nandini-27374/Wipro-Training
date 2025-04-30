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
    static int Sub(int a,int b)
    {
        return a-b;
    }
    static double Sub(double a,double b)
    {
        return a-b;
    }
     static int Mul(int a,int b)
    {
        return a*b;
    }
    static double Mul(double a,double b)
    {
        return a*b;
    }
    static void Main()
    {
        Console.WriteLine("int add: " +Add(3,4));
        Console.WriteLine("DoubleAdd: " + Add(2.5,4.3));
        Console.WriteLine("int sub: " +Sub(10,9));
        Console.WriteLine("DoubleSub: " + Sub(10.5,4.3));
        Console.WriteLine("int mul: " +Mul(3,4));
        Console.WriteLine("DoubleMul: " + Mul(2.5,4.3));
    }
}
