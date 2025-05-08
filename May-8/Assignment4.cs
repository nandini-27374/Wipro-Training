using System;
using System.Collections.Generic;

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
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 75000 },
            new Product { Id = 2, Name = "Smartphone", Price = 35000 },
            new Product { Id = 1, Name = "Tablet", Price = 20000 },
            new Product { Id = 1, Name = "Monitor", Price = 15000 },
            new Product { Id = 1, Name = "Keyboard", Price = 2000 }
        };

        products.Sort((x, y) => y.Price.CompareTo(x.Price));

        Product highestPriceProduct=products[0];
        Console.WriteLine($"Highest Price Product: {highestPriceProduct.Name}-{highestPriceProduct.Price}");
    }
}