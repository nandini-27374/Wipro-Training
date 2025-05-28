using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        string query = @"SELECT p.CategoryID, SUM(UnitPrice* od.Quantity) AS TotalSales  FROM [Order Details] od JOIN Products p ON od.ProductID=p.ProductID GROUP BY p.CategoryID;";

        DataTable dataTable=new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))    

        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
        {
            adapter.Fill(dataTable);
        }

        foreach(DataRow row in dataTable.Rows)
        {
            int categoryId = Convert.ToInt32(row["CategoryID"]);
            decimal totalSales = Convert.ToDecimal(row["TotalSales"]);
            Console.WriteLine($"CategoryID:{categoryId}, TotalSales:{totalSales}");
        }
    }
}
