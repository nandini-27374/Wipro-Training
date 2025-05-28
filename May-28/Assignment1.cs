
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string connectionstring = "Data Source = (localdb)\\MSSQLLocalDB ; Initial Catalog = NorthWind; Integrated Security=true";

        string query = "SELECT CustomerID, CompanyName,Country from dbo.Customers";

        SqlConnection connection = new SqlConnection(connectionstring);

        SqlCommand command = new SqlCommand(query, connection);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("CustomerID".PadRight(20) + "ComanyName".PadRight(40) + "Country");

            while (reader.Read())
            {
                string CompanyName = reader[1].ToString();
                string Country = reader[2].ToString();

                Console.WriteLine(reader[0].ToString().PadRight(20) + CompanyName.PadRight(40) + Country);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}

