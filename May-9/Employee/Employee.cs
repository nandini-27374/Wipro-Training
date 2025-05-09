using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int EmployeeId;
        public string Name;
        public string Department;
        public int Salary;

        public void PrintDetails()
        {
            Console.WriteLine("Employee_ID:" + EmployeeId);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("Salary:" + Salary);
        }
        public void UpdateSalary()
        {
            Salary = Salary + 2000;
            Console.WriteLine("Updated Salary is:" + Salary);
        }
        public void AnnualSalary()
        {
            int AnnualSalary = Salary * 12;
            Console.WriteLine("Annual Salary is:" + AnnualSalary);
        }
    }
}