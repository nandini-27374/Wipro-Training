/*Create a new web application mvc project

create Employee.cs

inside write the below code

using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int EmployeeAge { get; set; } 
    }
}

then create controller for the employee

in package manage console do this below operations 1,Add-Migration InitialCreate 2.Update-Database

see wether the table is created or not in SQL Server Object Exlorer

again give below program

using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int EmployeeAge { get; set; } 

        public Salary Salary { get; set; }

    }
    public class Salary
    {
        public int SalaryId { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

give commands below 

Add-Migration -Name RelationshipMigration -Context WebApplication14Context

Update-Database -Migration RelationshipMigration -Context WebApplication14Context

See wether the Salary column is present or not in SQL serverObject Explorer

give below commands

Add-Migration -Name RemoveGradeMigration -Context WebApplication14Context

Update-Database -Migration RemoveGradeMigration -Context WebApplication14Context

Add the column as EmpDob 

*/

using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int EmployeeAge { get; set; } 

        public String EmpDob { get; set; }
    }
}

/*
save it and run below codes in the package app console

Add-Migration -Name AddEmpDobMigration -Context WebApplication14Context

Update-Database -Migration AddEmpDobMigration -Context WebApplication14Context

goto the SQL Server Object Explorer refresh it you can see the EmpDob column then do the below operations


now go to Views open the _Layout.cshtml


 <li class="nav-item">
     <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>
 </li>
 <li class="nav-item">
     <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
 </li>
 <li class="nav-item">
     <a class="nav-link text-dark" asp-area="" asp-controller="Employees" asp-action="Index">Employees</a>
 </li>

change like this and run the program by clicking http button in the top side , you can see the Employee information in webpage like columns*/