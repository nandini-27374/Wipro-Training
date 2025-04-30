using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num=146;
        int rev=0;
        while (num!=0)
        {
            int digit=num%10;
            rev=rev*10+digit;
            num=num/10;
        }
        Console.WriteLine(rev);
    }
}
