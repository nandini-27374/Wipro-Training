using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList students= new ArrayList();
        
        students.Add("Yamuna");
        students.Add("Bavi");
        students.Add("Joshu");
        students.Add("Divya");
        students.Add("Anjali");
        
        string searchname="Yamuna";
     
        if (students.Contains(searchname))
        {
            Console.WriteLine("Found");
        }
        else
        {
            Console.WriteLine("Not found");
        }
        students.RemoveAt(1);
        
        Console.WriteLine("Final list");
        
        foreach (string name in students)
        {
        Console.WriteLine(name);
        }
    }
}