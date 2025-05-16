using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        // RIGHT JOIN query to retrieve all products and their corresponding suppliers
        string queryString =
            "SELECT Suppliers.City, Suppliers.CompanyName, Products.UnitPrice, Products.ProductName " +
            "FROM Suppliers RIGHT JOIN Products ON Suppliers.SupplierID = Products.SupplierID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();

                Console.WriteLine("City".PadRight(20) + "Company Name".PadRight(40) +
                                  "Unit Price".PadRight(20) + "Product Name");
                Console.WriteLine(new string('-', 20) + new string('-', 40) +
                                  new string('-', 20) + new string('-', 30));

                while (rdr.Read())
                {
                    string city = rdr.IsDBNull(0) ? "N/A" : rdr.GetString(0);
                    string companyName = rdr.IsDBNull(1) ? "N/A" : rdr.GetString(1);
                    string unitPrice = rdr.IsDBNull(2) ? "N/A" : rdr.GetDecimal(2).ToString("C");
                    string productName = rdr.IsDBNull(3) ? "N/A" : rdr.GetString(3);

                    Console.WriteLine(city.PadRight(20) + companyName.PadRight(40) +
                                      unitPrice.PadRight(20) + productName);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}