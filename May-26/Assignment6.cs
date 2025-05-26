/*

6. Custom Collection Filter with LINQ – Inventory System
Task:
Create an Item class with Name , Type , Stock , Price .
Add 15 items to List<Item> .
Use LINQ to:
Filter low stock items
Group by Type
Find highest priced item in each group

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Documents;

class Item
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var items = new List<Item>
        {
            new Item { Name = "Laptop", Type = "Electronics", Stock = 5, Price = 999.99m },
            new Item { Name = "Smartphone", Type = "Electronics", Stock = 2, Price = 799.99m },
            new Item { Name = "Headphones", Type = "Electronics", Stock = 10, Price = 199.99m },
            new Item { Name = "Jeans", Type = "Clothing", Stock = 3, Price = 49.99m },
            new Item { Name = "T-Shirt", Type = "Clothing", Stock = 8, Price = 19.99m },
            new Item { Name = "Jacket", Type = "Clothing", Stock = 1, Price = 89.99m },
            new Item { Name = "Novel", Type = "Books", Stock = 15, Price = 14.99m },
            new Item { Name = "Cookbook", Type = "Books", Stock = 0, Price = 29.99m },
            new Item { Name = "Notebook", Type = "Books", Stock = 4, Price = 9.99m },
            new Item { Name = "Action Figure", Type = "Toys", Stock = 6, Price = 24.99m },
            new Item { Name = "Puzzle", Type = "Toys", Stock = 2, Price = 14.99m },
            new Item { Name = "Board Game", Type = "Toys", Stock = 3, Price = 34.99m },
            new Item { Name = "Blender", Type = "Kitchen", Stock = 7, Price = 59.99m },
            new Item { Name = "Toaster", Type = "Kitchen", Stock = 5, Price = 39.99m },
            new Item { Name = "Microwave", Type = "Kitchen", Stock = 2, Price = 89.99m }
        };

        var lowStockItems = items.Where(item => item.Stock < 5);

        var highestPricedItemsByType = lowStockItems
            .GroupBy(item => item.Type)
            .Select(group => group.OrderByDescending(item => item.Price).First());

        foreach (var item in highestPricedItemsByType)
        {
            Console.WriteLine($"Type: {item.Type}, Name: {item.Name}, Stock: {item.Stock}, Price: {item.Price}");
        }
    }
}

/*

Output:

Type: Electronics, Name: Smartphone, Stock: 2, Price: 799.99
Type: Clothing, Name: Jacket, Stock: 1, Price: 89.99
Type: Books, Name: Cookbook, Stock: 0, Price: 29.99
Type: Toys, Name: Board Game, Stock: 3, Price: 34.99
Type: Kitchen, Name: Microwave, Stock: 2, Price: 89.99

*/
