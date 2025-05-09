using System;

class Student
{

    public int RollNumber;
    public string Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($" RollNumber: {RollNumber}");
        Console.WriteLine($" Name: {Name}");
        Console.WriteLine($" Marks: {Marks}");

    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.RollNumber = 101;
        student1.Name = "Amit";
        student1.Marks = 85;

        student1.PrintDetails();
    }
}