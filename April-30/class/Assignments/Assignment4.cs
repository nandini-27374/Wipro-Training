using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int num=1;num*num<=100;num++)
        {
            int sqr=num*num;
            Console.WriteLine(sqr);
        }
    }
}
