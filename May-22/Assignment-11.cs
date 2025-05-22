/*

Sort products by price using LINQ.
Instructions:
1. Create a Product class with Id , Name , Price .
2. Add 5–6 products to a list.
3. Sort the products by price in descending order using LINQ.
4. Print the sorted list.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 80000.00m },
            new Product { Id = 2, Name = "Smartphone", Price = 30000.00m },
            new Product { Id = 3, Name = "Tablet", Price = 25000.00m },
            new Product { Id = 4, Name = "Smartwatch", Price = 15000.00m },
            new Product { Id = 5, Name = "Headphones", Price = 5000.00m }
        };

        var sortedProducts = products.OrderByDescending(p => p.Price);

        Console.WriteLine("Products sorted by price (highest to lowest):");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price:{product.Price}");
        }
    }
}

/*

Output:

Products sorted by price(highest to lowest):
ID: 1, Name: Laptop, Price: 80000.00
ID: 2, Name: Smartphone, Price: 30000.00
ID: 3, Name: Tablet, Price: 25000.00
ID: 4, Name: Smartwatch, Price: 15000.00
ID: 5, Name: Headphones, Price: 5000.00

*/