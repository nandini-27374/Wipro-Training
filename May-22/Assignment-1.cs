/*

Store and display student names using a List<string> .
Instructions:
1. Create a List<string> called students .
2. Add 5 names to the list.
3. Display all names using a foreach loop.
4. Sort the list and display it again.

*/

using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> students = new List<string> { "Nandini", "Sweety", "Chocky" };
        students.Add("Abhi");
        students.Add("Bhavya");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        students.Sort();

        Console.WriteLine("After sorting the list: ");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}

/*
Output:

Nandini
Sweety
Chocky
Abhi
Bhavya
After sorting the list:
Abhi
Bhavya
Chocky
Nandini
Sweety

*/