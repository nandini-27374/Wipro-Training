/*Create a new web application mvc project

create Department.cs

inside write the below code

namespace WebApplication16.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

    }
}

then create controller for the Department

in package manage console do this below operations 1,Add-Migration InitialCreate 2.Update-Database

see wether the table is created or not in SQL Server Object Exlorer

Add the column as Description

*/

namespace WebApplication16.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

    }
}
/*
save it and run below codes in the package app console

Add-Migration -Name AddDescriptionMigration -Context WebApplication16Context

Update-Database -Migration AddDescriptionMigration -Context WebApplication16Context

goto the SQL Server Object Explorer refresh it you can see the Description column then do the below operations

now go to Views open the _Layout.cshtml


 <li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>
</li>
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
</li>
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Departments" asp-action="Index">Departments</a>
</li>

change like this and run the program by clicking http button in the top side , you can see the Department information in webpage like columns*/