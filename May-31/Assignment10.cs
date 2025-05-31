/*

10. Student Gradebook with LINQ + Collections
Concepts: Dictionary, List, LINQ Task:
Accept marks of students in multiple subjects
Calculate average, highest, and lowest per student
Find top 3 scorers using LINQ.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student
            {
                Name = "Cherry",
                Marks = new Dictionary<string, int>
                {
                    { "Math", 85 },
                    { "Science", 90 },
                    { "English", 78 }
                }
            },
            new Student
            {
                Name = "Joshu",
                Marks = new Dictionary<string, int>
                {
                    { "Math", 92 },
                    { "Science", 88 },
                    { "English", 95 }
                }
            },
            new Student
            {
                Name = "Aditya",
                Marks = new Dictionary<string, int>
                {
                    { "Math", 70 },
                    { "Science", 75 },
                    { "English", 80 }
                }
            },
            new Student
            {
                Name = "Abhi",
                Marks = new Dictionary<string, int>
                {
                    { "Math", 88 },
                    { "Science", 93 },
                    { "English", 85 }
                }
            }
        };

        foreach (var student in students)
        {
            var average = student.Marks.Values.Average();
            var highest = student.Marks.Values.Max();
            var lowest = student.Marks.Values.Min();

            Console.WriteLine($"\nStudent: {student.Name}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Highest Marks: {highest}");
            Console.WriteLine($"Lowest Marks: {lowest}");
        }

        var topScorers = students
            .Select(s => new
            {
                Name = s.Name,
                Average = s.Marks.Values.Average()
            })
            .OrderByDescending(s => s.Average)
            .Take(3);

        Console.WriteLine("\nTop 3 Scorers:");
        foreach (var scorer in topScorers)
        {
            Console.WriteLine($"{scorer.Name} - Average Marks: {scorer.Average:F2}");
        }
    }
}

/*

Output:

Student: Cherry
Average Marks: 84.33
Highest Marks: 90
Lowest Marks: 78

Student: Joshu
Average Marks: 91.67
Highest Marks: 95
Lowest Marks: 88

Student: Aditya
Average Marks: 75.00
Highest Marks: 80
Lowest Marks: 70

Student: Abhi
Average Marks: 88.67
Highest Marks: 93
Lowest Marks: 85

Top 3 Scorers:
Joshu - Average Marks: 91.67
Abhi - Average Marks: 88.67
Cherry - Average Marks: 84.33

*/