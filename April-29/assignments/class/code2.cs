
using System;

public class HelloWorld
{
    static int Add(int a,int b)
    {
        return a + b;
    }
    
    static void Main()
    {
        int num1=20;
        int num2=30;
        Console.WriteLine ("Addition:" +Add(num1,num2));
    }
}
