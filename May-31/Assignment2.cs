/*

2. Employee Directory with LINQ
Concepts: Collections, LINQ, Filtering, Sorting Task:
Create a list of Employee objects with ID , Name , Department , Salary
Filter employees by department
Sort by salary descending
Find average salary per department.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

class Employee
{
    public int ID;
    public string Name;
    public string Department;
    public decimal Salary;
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 1,Name="Abhi", Department="HR",Salary=50000 },
            new Employee { ID = 2,Name="Cherry", Department="IT",Salary=55000 },
            new Employee { ID = 3,Name="Joshu", Department="Sales",Salary=40000 },
            new Employee { ID = 4,Name="Guna", Department="HR",Salary=56000 },
            new Employee { ID = 1,Name="Puri", Department="IT",Salary=41000 }
        };
        var itEmployees = employees.Where(e => e.Department == "IT");

        Console.WriteLine("Employees in IT Department");
        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"{emp.Name} having salary {emp.Salary}");
        }

        var sortedEmployees = employees.OrderByDescending(e => e.Salary);

        Console.WriteLine("\nEmployees sorted by salary (descending):");
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} having salary is {emp.Salary}");
        }

        var avgSalaryPerDept = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) });

        Console.WriteLine("\nAverage salary per department:");
        foreach (var dept in avgSalaryPerDept)
        {
            Console.WriteLine($"{dept.Department} - {dept.AverageSalary}");
        }
    }
}

/*

Output:
Employees in IT Department
Cherry having salary 55000
Puri having salary 41000

Employees sorted by salary (descending):
Guna having salary is 56000
Cherry having salary is 55000
Abhi having salary is 50000
Puri having salary is 41000
Joshu having salary is 40000

Average salary per department:
HR - 53000
IT - 48000
Sales - 40000

*/