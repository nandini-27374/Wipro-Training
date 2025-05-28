using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        string query = @"SELECT o.OrderID, c.CompanyName, o.OrderDate FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

        using (SqlConnection connection = new SqlConnection(connectionstring))

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            connection.Open();

            using (SqlDataReader reader=command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    string companyName=reader.GetString(1);
                    DateTime orderDate=reader.GetDateTime(2);

                    Console.WriteLine($"OrderID:{orderId}, CompanyName:{companyName} , OrderDate.{orderDate.ToShortDateString()}");
                }
            }
        }
    }
}
