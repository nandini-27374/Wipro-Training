using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter product ID to delete:");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            string connectionString= "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";
            string query = "DELETE FROM Products WHERE ProductID=@ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString)) 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int productId = 0;
                command.Parameters.AddWithValue("@ProductID", productId);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine(rowsAffected > 0 ? "Product deleted successfully." : "Product not found.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Product ID.");
        }
    }
}
