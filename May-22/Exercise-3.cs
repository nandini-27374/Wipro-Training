/*

Use both an interface and abstract class to model employees.
Instructions:
1. Create an interface IAttendance with method MarkAttendance()
2. Create an abstract class Staff with:
Properties: Id , Name , Department
Abstract method: CalculateSalary()
3. Create classes PermanentStaff and ContractStaff :

Implement both IAttendance and Staff
Implement CalculateSalary() differently
4. In Main() , use polymorphism to work with a list of staff.

*/

using System;
using System.Collections.Generic;
    
interface IAttendance
{
    void MarkAttendance();
}

abstract class Staff : IAttendance
{
    public int Id;
    public string Name;
    public string Department;

    public abstract decimal CalculateSalary();
    public abstract void MarkAttendance();
}

class PermanentStaff : Staff
{
    public override decimal CalculateSalary()
    {
        return 50000;
    }
    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent) attendance marked.");
    }
}

class ContractStaff : Staff
{
    public int HoursWorked;
    public decimal HourlyRate;

    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Contract) attendance marked.");
    }
}

class Program
{
    static void Main()
    {
        var staffList = new List<Staff>
        {
            new PermanentStaff { Id = 1, Name = "Yamuna", Department = "HR" },
            new ContractStaff { Id = 2, Name = "Bhavya", Department = "IT", HoursWorked = 160, HourlyRate = 300 }
        };

        foreach (var staff in staffList)
        {
            staff.MarkAttendance();
            Console.WriteLine($"Name: {staff.Name}, Department: {staff.Department}, Salary:{staff.CalculateSalary()}\n");
        }
    }
}

/*

Output:

Yamuna(Permanent) attendance marked.
Name: Yamuna, Department: HR, Salary: 50000

Bhavya(Contract) attendance marked.
Name: Bhavya, Department: IT, Salary: 48000

*/


