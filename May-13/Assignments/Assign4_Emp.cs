using System;

abstract class Employee
{
    public void ShowBasicInfo()
    {
        Console.WriteLine("Employee details");
    }

    //abstract method
    public abstract void CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine($"Salary:Basic+Allowance");
    }
}

class PartTimeEmployee: Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary:Hourly rate*Hours Worked");
    }
}
class Program
{
    static void Main()
    {
        Employee fulltime = new FullTimeEmployee();
        Employee parttime= new PartTimeEmployee();

        fulltime.ShowBasicInfo();
        fulltime.CalculateSalary();

        parttime.ShowBasicInfo();
        parttime.CalculateSalary();
    }
}