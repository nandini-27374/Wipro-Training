using System;
using System.Linq;

    public class Employee
    {   
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
    }
    class Program3
    {
    static void Main(string[] args)
    {
        Employee[] employeeArray ={
                    new Employee() {EmployeeID =1,EmployeeName="John",Age=18},
                    new Employee() {EmployeeID =2,EmployeeName="Steve",Age=23},
                    new Employee() {EmployeeID =3,EmployeeName="Bill",Age=25},
                    new Employee() {EmployeeID =4,EmployeeName="Ram",Age=20},
                    new Employee() {EmployeeID =5,EmployeeName="Ron",Age=31},
                    new Employee() {EmployeeID =6,EmployeeName="Chris",Age=17},
                    new Employee() {EmployeeID =7,EmployeeName="Rob",Age=19},
                };
            Employee[] teenAgerEmployees = employeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            Employee bill = employeeArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();
            Employee Employee5 = employeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();
            
            foreach(Employee emp in teenAgerEmployees)
            {
                Console.WriteLine(emp.EmployeeName);
            }

            Console.WriteLine(bill.EmployeeName);
            Console.WriteLine(Employee5.EmployeeID);
        }   
    }