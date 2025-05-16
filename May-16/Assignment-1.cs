using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string queryString =
            "SELECT ContactName, City, CompanyName FROM dbo.Suppliers";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Define column widths
                int contactNameWidth = 30;
                int cityWidth = 20;
                int companyNameWidth = 40;

                // Print headers
                Console.WriteLine(
                    "Contact Name".PadRight(contactNameWidth) +
                    "City".PadRight(cityWidth) +
                    "Company Name".PadRight(companyNameWidth)
                );

                // Print underlines for each header
                Console.WriteLine(
                    new string('-', contactNameWidth) +
                    new string('-', cityWidth) +
                    new string('-', companyNameWidth)
                );

                // Read and display data
                while (reader.Read())
                {
                    string contactName = reader.IsDBNull(0) ? "N/A" : reader.GetString(0);
                    string city = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                    string companyName = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);

                    Console.WriteLine(
                        contactName.PadRight(contactNameWidth) +
                        city.PadRight(cityWidth) +
                        companyName.PadRight(companyNameWidth)
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
