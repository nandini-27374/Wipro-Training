abstract class Vehicle
{
    public string Brand;
    public int Year;

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand},Year: {Year}");
    }

    //abstract method
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting with the key");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting with the kick");
    }
}
class Program
{
    static void Main()
    {
        Bike bike = new Bike();
        bike.Start();
    }
}