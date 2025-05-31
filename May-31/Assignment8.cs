/*

8. Invoice Generator (Interface + Abstraction)
Concepts: Abstract Class, Interface, Inheritance Task:
Abstract class Invoice with CalculateTotal()
Subclasses for RetailInvoice , WholesaleInvoice
Interface IPrintable with Print()
Print an invoice with product list, tax, and discount.

*/

using System;

interface IPrintable
{
    void Print();
}

class Product
{
    public string Name { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Total => Quantity * UnitPrice;
}

abstract class Invoice : IPrintable
{
    public Product Item { get; set; }

    public decimal TaxRate { get; set; }

    public decimal DiscountRate { get; set; }

    public abstract decimal CalculateTotal();

    public void Print()
    {
        Console.WriteLine($"\nProduct:{Item.Name}");
        Console.WriteLine($"Quantity:{Item.Quantity}");
        Console.WriteLine($"Unit Price:{Item.UnitPrice}");
        Console.WriteLine($"Subttotal:{Item.Total}");
        Console.WriteLine($"Total:{CalculateTotal()}");
    }
}

class RetailInvoice : Invoice
{
    public override decimal CalculateTotal()
    {
        decimal tax = Item.Total * TaxRate;
        decimal discount = Item.Total * DiscountRate;
        return Item.Total + tax - discount;
    }
}

class WholesaleInvoice : Invoice
{
    public override decimal CalculateTotal()
    {
        decimal discount = Item.Total * DiscountRate;
        decimal taxableAmount = Item.Total - discount;
        decimal tax = taxableAmount * TaxRate;
        return taxableAmount + tax;
    }
}

class Program
{
    static void Main()
    {
        var product = new Product
        {
            Name = "USB Drive",
            Quantity = 1,
            UnitPrice = 500.00m
        };

        Invoice retailInvoice = new RetailInvoice
        {
            Item = product,
            TaxRate = 0.08m,
            DiscountRate = 0.05m
        };

        Invoice wholesaleInvoice = new WholesaleInvoice
        {
            Item = product,
            TaxRate = 0.05m,
            DiscountRate = 0.10m
        };

        retailInvoice.Print();
        wholesaleInvoice.Print();
    }
}

