using System;

interface IOrder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}

class DineInOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing dine-in order for {item}");
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling dine-in order for {item}");
    }

}

class TakeawayOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing takeaway order for {item}");
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling dine-in order for {item}");
    }
}

class Program1
{
    static void Main()
    {
        IOrder dinein = new DineInOrder();
        IOrder takeaway= new TakeawayOrder();

        dinein.PlaceOrder("Pasta");
        dinein.CancelOrder("Pasta");

        takeaway.PlaceOrder("Burger");
        takeaway.CancelOrder("Burger");
    }
}