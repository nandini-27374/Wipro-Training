using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();     
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                string orderQuery = @"INSERT INTO Orders (CustomerID, OrderDate) VALUES (@CustomerID, @OrderDate);SELECT SCOPE_IDENTITY();";

                SqlCommand orderCommand = new SqlCommand(orderQuery, con, transaction);

                orderCommand.Parameters.AddWithValue("@CustomerID", "AlfKI");
                orderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                string Query = @"INSERT INTO [Order Details]
                                (OrderID,ProductID,UnitPrice,Quantity)
                                VALUES(@OrderID,@ProductID,@UnitPrice,@Quantity)";
                SqlCommand detailCommand= new SqlCommand(Query, con, transaction);

                detailCommand.Parameters.AddWithValue("@OrderID", orderId);
                detailCommand.Parameters.AddWithValue("@ProductID", 1);
                detailCommand.Parameters.AddWithValue("@UnitPrice", 18.00);
                detailCommand.Parameters.AddWithValue("@Quantity", 2);

                detailCommand.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine($"Order {orderId} created successfully!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
