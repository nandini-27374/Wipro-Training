using System;
using System.Collections.Generic;

class Prgram
{
    static void Main()
    {
        List<string> employee = new List<string>() {"Yamuna","Bhavya","Cherry","Abhi","Adhitya"};

        employee.Remove("Adhitya");

        if (employee.Contains("Bhavya"))
        {
            Console.WriteLine("Bhavya is in the list");
        }
        Console.WriteLine("Total number of employees are: "+ employee.Count);
    }
}