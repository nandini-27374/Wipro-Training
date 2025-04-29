using System;

public class HelloWorld
{
    //	method for addition
    static int Add(int a,int b)
    {
        return a + b;
    }
    static int Sub(int a,int b)
    {
        return a - b;
    }
    static int Mul(int a,int b)
    {
        return a * b;
    }
    static int Div(int a,int b)
    {
        return a / b;
    }
    
    static void Main()
    {
        int num1=60;
        int num2=30;
       //calling methods
        Console.WriteLine ("Addition:" +Add(num1,num2));
        Console.WriteLine ("Subtraction:" +Sub(num1,num2));
        Console.WriteLine ("Multiplication:" +Mul(num1,num2));
        Console.WriteLine ("Division:" +Div(num1,num2));
    }
}
