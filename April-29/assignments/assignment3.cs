using System;

public class multiplication
{
    static void Main()
    {
        int num1 =int.Parse(Console.ReadLine());
        int num2 =int.Parse(Console.ReadLine());
        int num3 =int.Parse(Console.ReadLine());
        
        int largest = num1;
        if (num2 > largest)
        {
            largest =num2;
        }
        if (num3 >largest)
        {
            largest =num3;
        }
        else
        {
            Console.WriteLine("largest number is:" + largest);
        }
    }
}
