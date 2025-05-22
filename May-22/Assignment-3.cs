/*

Filter products with price > 500 using LINQ.
Instructions:
1. Create a Product class with Name , Price .
2. Create a List<Product> and add 5 items.
3. Use LINQ to filter products where Price > 500 .
4. Display the filtered list.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Product
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product {Name = "Laptop",Price=750},
            new Product {Name = "SmartPhone",Price=1200},
            new Product {Name="HeadPhones",Price=150},
            new Product{Name="Monitor",Price=300},
            new Product {Name="Tablet",Price=600}
        };

        var expensiveProducts = products.Where(p => p.Price > 500);

        Console.WriteLine("Products with price >500: ");

        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"Name: {product.Name},Price: {product.Price}");
        }
    }
}

/*

Output:

Products with price > 500:
Name: Laptop,Price: 750
Name: SmartPhone,Price: 1200
Name: Tablet,Price: 600

*/