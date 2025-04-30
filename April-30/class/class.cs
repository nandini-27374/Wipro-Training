using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int marks=78;
        
        if (marks>=90)
        {
            Console.WriteLine("A");
        }
        
        else if (marks>=75)
        {
            Console.WriteLine("B");
        }
        
        else if (marks<=60)
        {
            Console.WriteLine("C");
        }
        
        else
        {
            Console.WriteLine("D");
        }
    }
}
