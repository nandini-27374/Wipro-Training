using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        string customerId=Console.ReadLine();

        using (SqlConnection connection =new SqlConnection(connectionstring))
        {
            connection.Open();

            using (SqlCommand command =new SqlCommand("CustOrderHist",connection))
            {
                command.CommandType=CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CustomerID", customerId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine($"Order history for customer '{customerId}':\n");

                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);
                        Console.WriteLine($"Product:{productName,-35} Total Ordered:{total}");
                    }
                }
            }

        }
    }
}
