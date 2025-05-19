using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }
}

class Program1
{
    static void Main(string[] args)
    {
        // Create a List<Employee>
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Cherry", 50000m),
            new Employee(102, "Abhi", 60000m),
            new Employee(103, "Yamuna", 75000m),
            new Employee(104, "Bhavya", 65000m),
            new Employee(105, "Nandini", 72000m)
        };

        // Find employee with highest salary
        Employee highestPaid = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"Highest Salary: {highestPaid.Name} - {highestPaid.Salary:C}");

        // Store ID and Name in a Dictionary
        Dictionary<int, string> employeeDirectory = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            employeeDirectory[emp.EmployeeID] = emp.Name;
        }

        // Display dictionary contents
        Console.WriteLine("\nEmployee Directory:");
        foreach (var entry in employeeDirectory)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }

        // Search for an employee by ID
        Console.Write("Employee ID:");
        int id = int.Parse(Console.ReadLine());

        if (employeeDirectory.ContainsKey(id))
            Console.WriteLine("Found: " + employeeDirectory[id]);
        else
        {
            Console.WriteLine("Employee ID not found.");
        }
    }
}

