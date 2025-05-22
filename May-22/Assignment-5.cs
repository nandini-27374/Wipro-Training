/*

Group employees by department.
Instructions:
1. Create an Employee class with Name , Department .
2. Add 6 employees (across 2–3 departments).
3. Use LINQ group by to group them.
4. Print employees under each department.

*/

using System;
using System.Collections.Generic;
using System.Linq;


class Employee
{
    public string Name { get; set; }

    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee {Name="Chandrika",Department="HR"},
            new Employee {Name="Rajesh",Department="IT"},
            new Employee {Name="Rakesh",Department="HR"},
            new Employee {Name="Rupesh",Department="Finance"},
            new Employee {Name="Haneesh",Department="IT"},
            new Employee {Name="Thanmai",Department="Finance"}
        };

        var GroupEmployees = employees.GroupBy(e => e.Department);

        foreach (var group in GroupEmployees)
        {
            Console.WriteLine($"Department:{group.Key}");

            foreach (var employee in group)
            {
                Console.WriteLine($"{employee.Name}");
            }
            Console.WriteLine();
        }
    }
}

/*

Output:

Department: HR
Chandrika
Rakesh

Department:IT
Rajesh
Haneesh

Department:Finance
Rupesh
Thanmai

*/