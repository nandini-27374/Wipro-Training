/*

Use LINQ to count how many students scored above the average.
Instructions:
1. Create a Student class with Name , Marks .
2. Add at least 5 students.
3. Calculate average marks using LINQ: .Average()
4. Use LINQ to count how many students scored above average.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }

    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student {Name="Bhavya",Marks=98},
            new Student {Name="Anhi",Marks=97},
            new Student {Name="Cherry",Marks=98},
            new Student {Name="Kumar",Marks=96},
            new Student {Name="Nandini",Marks=95}
        };

        double average = students.Average(s => s.Marks);

        int countabvavg = students.Count(s => s.Marks > average);

        Console.WriteLine($"Average Marks:{average}");

        Console.WriteLine($"Number of students scoring above average : {countabvavg}");
    }
}

/*

Output:

Average Marks:96.8
Number of students scoring above average : 3

*/