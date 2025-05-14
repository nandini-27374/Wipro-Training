using System;

abstract class FoodOrder
{
    public void Orderinfo()
    {
        Console.WriteLine("Placing food order");
    }

    //abstract method
    public abstract void PlaceOrder(string item);
}

class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fast Food Outlet");
    }
}

class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at fine dining Restaurent");
    }
}
class Program
{
    static void Main()
    {
        FoodOrder fastfood = new FastFoodOrder();
        FoodOrder finefood = new FineDiningOrder();

        fastfood.Orderinfo();
        fastfood.PlaceOrder("Gobhi");

        finefood.Orderinfo();
        finefood.PlaceOrder("Dosa");
    }
}