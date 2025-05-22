/*

Build a salary lookup table using Dictionary<int, decimal> .
Instructions:
1. Use Employee ID as the key, Salary as the value.
2. Add 4–5 employees.
3. Ask the user to enter an Employee ID.
4. Display their salary if found.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        var salary = new Dictionary<int, decimal>
        {
            {101,50000.00m },
            {102,60000.00m },
            {103,55000.00m },
            {104,70000.00m }
        };

        Console.WriteLine("Enter EmployeeID: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int employeeId))
        {
            if (salary.TryGetValue(employeeId, out decimal sal))
            {
                Console.WriteLine($"salary for Employee ID {employeeId}:{sal}");
            }
            else
            {
                Console.WriteLine($"employee ID {employeeId} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid employeeId");
        }
    }
}

/*

Output:

Enter EmployeeID:
102
salary for Employee ID 102:60000.00

*/