using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString= "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =Northwind;Integrated Security=true";

        string query = "SELECT ProductID,ProductName,UnitslnStock FROM Products";

        DataSet dataSet = new DataSet();

        using (SqlConnection connection = new SqlConnection(connectionString)) 

        using (SqlDataAdapter adapter = new SqlDataAdapter(query,connection))
        {
            adapter.Fill(dataSet, "Products");
        }

        DataView view = new DataView(dataSet.Tables["Products"]);
        view.RowFilter = "UnitslnStock>20";

        Console.WriteLine("Products with UnitslnStock>20:\n");

        foreach (DataRowView row in view)
        {
            Console.WriteLine($"ProductID:{row["ProductID"]},ProductName:{row["ProductName"]},UnitslnStock:{row["UnitslnStock"]}");
        }
    }
}
