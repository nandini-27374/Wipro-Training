/*

2. Collection of Objects + LINQ – Student Rank List
Task:
Create Student class with Name , Marks , Grade .
Add 10 students to a List<Student> .
Use LINQ to:
Sort by marks (descending)
Group by grade
Project the top 3 students using .Take(3)

*/

using System;
using System.Collections.Generic;
using System.Linq;


public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }

    public string Grade { get; set; }

    public Student(string name, int marks, string grade)
    {
        Name = name;
        Marks = marks;
        Grade = grade;
    }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student("Bhavya",95,"A"),
            new Student("Yamuna",85,"B"),
            new Student("Cherry",87,"B"),
            new Student("Abhi",98,"A"),
            new Student("Nandini",95,"A"),
            new Student("Joshu",89,"B"),
            new Student("Chocky",93,"A"),
            new Student("Aditya",96,"A"),
            new Student("Sunil",78,"C"),
            new Student("Kumar",79,"C")
        };

        var topStudentsByGrade = students.OrderByDescending(s => s.Marks).GroupBy(s => s.Grade).Select(global => new { Grade = global.Key, TopStudents = global.Take(3) });

        foreach (var group in topStudentsByGrade)
        {
            Console.WriteLine($"Grade:{group.Grade}");


            foreach (var student in group.TopStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Marks} marks");
            }
            Console.WriteLine();
        }
    }
}

/*

Output:

Grade: A
Abhi - 98 marks
Aditya - 96 marks
Bhavya - 95 marks

Grade:B
Joshu - 89 marks
Cherry - 87 marks
Yamuna - 85 marks

Grade:C
Kumar - 79 marks
Sunil - 78 marks

*/