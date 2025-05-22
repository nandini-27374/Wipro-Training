
/*

Build a simple shopping cart system using object composition.
Instructions:
1. Create class Product with: Id , Name , Price
2. Create class CartItem with: Product , Quantity , GetTotalPrice()
3. Create class ShoppingCart with:
List of CartItem s
Methods: AddItem() , RemoveItem() , GetCartTotal()
4. In Main() , add 2–3 products and print total cart value.

*/

using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}
class CartItem
{
    public Product Product { get; }
    public int Quantity { get; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}
class ShoppingCart
{
    private List<CartItem> cartItems = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        cartItems.Add(new CartItem(product, quantity));
    }

    public void RemoveItem(Product product)
    {
        cartItems.RemoveAll(item => item.Product.Id == product.Id);
    }

    public decimal GetCartTotal()
    {
        decimal total = 0;
        foreach (var item in cartItems)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
}
class Program
{
    static void Main()
    {
        Product product1 = new Product(1, "Laptop", 75000);
        Product product2 = new Product(2, "Phone", 50000);
        Product product3 = new Product(3, "Headphones", 3000);

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(product1, 1);
        cart.AddItem(product2, 2);
        cart.AddItem(product3, 1);

        Console.WriteLine($"Total Cart Value: {cart.GetCartTotal()} INR");
    }
}

/*

Output:

Total Cart Value: 178000 INR

*/