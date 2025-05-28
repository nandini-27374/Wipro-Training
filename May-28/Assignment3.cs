using System;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source = (localdb)\\MSSQLLocalDB ; Initial Catalog = NorthWind; Integrated Security=true";

        String query = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice) VALUES (@ProductName, @SupplierID,@CategoryID, @UnitPrice)";

        using (SqlConnection connection =new SqlConnection(connectionstring))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", "Test Product");
                command.Parameters.AddWithValue("@SupplierID", 1);
                command.Parameters.AddWithValue("@CategoryID", 1);
                command.Parameters.AddWithValue("@UnitPrice", 25);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected>0)
                    {
                        Console.WriteLine("New product inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No product was inserted.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

/*

Output:

New product inserted successfully.

*/
