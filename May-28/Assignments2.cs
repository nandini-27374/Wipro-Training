
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer Id:");
        string customerId = Console.ReadLine();
        GetOrderByCustomer(customerId);
    }

    static void GetOrderByCustomer(string customerId)
    {
        string connectionstring = "Data Source = (localdb)\\MSSQLLocalDB ; Initial Catalog = NorthWind; Integrated Security=true";

        string query = "SELECT OrderID,ShipppedDate,ShipAddress from Orders where CustomerID=@CustomerId";

        using (SqlConnection connection = new SqlConnection(connectionstring)) 

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@CustomerID", customerId);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int orderId = reader["OrderID"] as int? ?? 0;
                        string shippedDate = reader["ShippedDate"] is DateTime dt ? dt.ToShortDateString() : "N/A";
                        string shipAddress = reader["ShipAddress"] as string ?? "N/A";

                        Console.WriteLine($"OrderID:{orderId},ShippedDate:{shippedDate},ShipAddress:{shipAddress}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
