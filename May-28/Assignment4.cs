
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int employeeId=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter New Title: ");
        string newTitle=Console.ReadLine();

        string connectionstring = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        string query = "UPDATE Employees SET Title=@Title WHERE EmployeeID=@EmployeeID";

        using (SqlConnection connection = new SqlConnection(connectionstring))

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Title",newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            connection.Open();
            int rowsAffected=command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} row updated.");
        }
    }
}
