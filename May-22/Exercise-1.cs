/*

Create a class hierarchy for different types of rental vehicles.
Instructions:
1. Create an abstract class Vehicle with:
Properties: VehicleNumber , Brand , RatePerDay
Method: virtual CalculateRent(int days)
2. Create derived classes: Car , Bike , Truck
Each overrides CalculateRent() with specific logic (e.g., base +
surcharge)
3. In Main() , create a List<Vehicle> and display rent for each using
polymorphism.

*/

using System;
abstract class Vehicle
{
    public string Number;
    public string Brand;
    public decimal RatePerDay;

    public Vehicle(string number, string brand, decimal rate)
    {
        Number = number;
        Brand = brand;
        RatePerDay = rate;
    }

    public abstract decimal CalculateRent(int days);
}

class Car : Vehicle
{
    public Car(string number, string brand, decimal rate) : base(number, brand, rate) { }

    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days + 500;
    }
}

class Bike : Vehicle
{
    public Bike(string number, string brand, decimal rate) : base(number, brand, rate) { }

    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

class Truck : Vehicle
{
    public Truck(string number, string brand, decimal rate) : base(number, brand, rate) { }

    public override decimal CalculateRent(int days)
    {
        return RatePerDay * days + 1000;
    }
}

class Program
{
    static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Car("CAR123", "Toyota", 1000),
            new Bike("BIKE456", "Yamaha", 500),
            new Truck("TRUCK789", "Volvo", 2000)
        };

        int days = 3;

        foreach (var v in vehicles)
        {
            Console.WriteLine($"Vehicle: {v.Brand} - {v.Number}");
            Console.WriteLine($"Total Rent for {days} days: {v.CalculateRent(days)}\n");
        }
    }
}

/*

Output:

Vehicle: Toyota - CAR123
Total Rent for 3 days: 3500

Vehicle: Yamaha - BIKE456
Total Rent for 3 days: 1500

Vehicle: Volvo - TRUCK789
Total Rent for 3 days: 7000

*/