using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int day=3;
        switch (day)
        {
            case 1:
                Console.WriteLine("monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            default:
                Console.WriteLine("invalid day");
                break;
        }
        
    }
}
