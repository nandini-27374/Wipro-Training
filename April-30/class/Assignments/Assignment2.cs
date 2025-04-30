using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num=14;
        int sum=0;
        while (num!=0)
        {
            sum +=num%10;
            num=num/10;
        }
        Console.WriteLine(sum);
    }
}
