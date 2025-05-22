/*

Find top 3 scoring students using LINQ.
Instructions:
1. Create a Student class with Name , Marks .
2. Add 6 students to a list.
3. Use LINQ to get the top 3 by Marks.
4. Print the result.

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
        List<Student> students = new List<Student>
        {
            new Student {Name = "Nandini",Marks=92},
            new Student {Name = "Yamuna",Marks=93},
            new Student {Name="Bhavya",Marks=94},
            new Student{Name="Joshu",Marks=95},
            new Student {Name="Cherry",Marks=96},
            new Student {Name="Adhitya",Marks=98}
        };

        var TopStudents = students.OrderByDescending(s => s.Marks).Take(3);

        Console.WriteLine("Top 3 students are: ");
        foreach (var student in TopStudents)
        {
            Console.WriteLine($"Name:{student.Name},Marks:{student.Marks}");
        }
    }
}

/*

Output:

Top 3 students are:
Name: Adhitya,Marks: 98
Name: Cherry,Marks: 96
Name: Joshu,Marks: 95

*/