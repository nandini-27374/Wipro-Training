//create a new webapllication mvc project

// right click-->on models -->create student.cs class

//inside that write below code

/* 

using Microsoft.AspNetCore.Components.Routing;

namespace WebApplication5.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

    }  
}
*/

//create Controller for the student

//in Package manager console do this below commands 1. Add-Migration InitialCreate 2. Update-Database

/*
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
*/

//see the wether the table is created or not  in the SQL Server Object Explorer by refreshing it

//again give the below program

/*

using System.ComponentModel;

namespace WebApplication5.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

	public Grade Grade { get; set; }

    }  
    public class Grade
    {
	public int GradeId { get; set; }
	
	public string GradeName { get; set; }

	public string Section { get; set; }
	
	public ICollection<Student> Students { get; set; }
    }

}
*/

//give the cammand as below

// Add-Migration -Name RelationshipMigration -Context WebApplication5Context

// Update-Database -Migration RelationshipMigration -Context WebApplication5Context

/*
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Student");
        }
    }
}
*/

// see the wether the Grade column in the table is updated or not in the SQL Server Object Explorer after refreshing it

//then give below commands

// Add-Migration -Name RemoveGradeMigration -Context WebApplication5Context

// Update-Database -Migration RemoveGradeMigration -Context WebApplication5Context

/*
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGradeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
*/

//the grade column and its data will be losed in the table after refreshing the SQL Server Object Explorer

//now add the Email column in the table and give commands below

// Add-Migration -Name AddEmailMigration -Context WebApplication5Context

// Update-Database -Migration AddEmailMigration -Context WebApplication5Context

/*
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");
        }
    }
}
*/

// see the table in SQL Server object Explorer than the column Email will be created.
using Microsoft.AspNetCore.Components.Routing;

namespace WebApplication5.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string Email {  get; set; }

    }  
}
