using System;
class Program
{
    static int Add(int a,int b) => a+b;
    static int Sub(int a,int b) => a-b;
    static int Mul(int a,int b) => a*b;
    static double Div(int a,int b) => (b ==0 ) ? 0 : (double)a/b;
    
    static void Main()
    {
        Console.WriteLine("Add:" +Add(3,5));
        Console.WriteLine("Sub:" +Sub(10,7));
        Console.WriteLine("Mul:" +Mul(5,3));
        Console.WriteLine("Div:" +Div(100,4));
    }
   
}
