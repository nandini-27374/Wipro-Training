using System;
using System.Security.Cryptography;

using ConsoleApp1;

class Program
{
    public static void Main()
    {
        Employee employee1 = new Employee();
        employee1.EmployeeId = 1;
        employee1.Name = "Nandini";
        employee1.Department = "Development";
        employee1.Salary = 90000;

        employee1.PrintDetails();
        employee1.UpdateSalary();
        employee1.AnnualSalary();

        Console.WriteLine(" ");
    }
}