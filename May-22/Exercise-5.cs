/*

Allow users to enroll in courses using different input combinations.
Instructions:
1. Create class Course : Id , Title , Fee
2. Create interface IEnrollable with method Enroll()
3. Create class User with overloaded Enroll() :
Enroll(Course course)
Enroll(Course course, string couponCode)
Use coupon to reduce fee
4. Print enrolled courses and final amount.

*/

using System;
using System.Collections.Generic;

class Course
{
    public int Id;
    public string Title;
    public decimal Fee;

    public Course(int id, string title, decimal fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}

interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}

class User : IEnrollable
{
    public string Name;
    private List<(Course course, decimal finalFee)> enrolledCourses = new List<(Course, decimal)>();

    public User(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"{Name} enrolled in {course.Title} for ₹{course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        decimal discount = 0;
        if (couponCode == "SAVE10")
            discount = 0.10m;
        else if (couponCode == "SAVE20")
            discount = 0.20m;

        decimal finalFee = course.Fee * (1 - discount);
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"{Name} enrolled in {course.Title} with coupon '{couponCode}' for {finalFee}");
    }

    public void DisplayEnrolledCourses()
    {
        Console.WriteLine($"\n{Name}'s Enrolled Courses:");
        foreach (var (course, fee) in enrolledCourses)
        {
            Console.WriteLine($"- {course.Title} ({fee})");
        }
    }
}

class Program
{
    static void Main()
    {
        var course1 = new Course(1, "C# Basics", 5000);
        var course2 = new Course(2, "Advanced C#", 8000);

        var user = new User("Yamuna");

        user.Enroll(course1);
        user.Enroll(course2, "SAVE10");

        user.DisplayEnrolledCourses();
    }
}

/*

Output:

Yamuna enrolled in C# Basics for ?5000
Yamuna enrolled in Advanced C# with coupon 'SAVE10' for 7200.00

Yamuna's Enrolled Courses:
- C# Basics (5000)
- Advanced C# (7200.00)

*/