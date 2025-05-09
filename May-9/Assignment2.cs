using System;
using System.Security.Cryptography;


using ConsoleApp1;
class Vehical
{
    public string Make;
    public string Model;

    public void DisplayVehical()
    {
        Console.WriteLine($"Make:{Make}");
        Console.WriteLine($"Model: {Model}");
    }
}

class Car : Vehical
{
    public string FuelType;
    public void DisplayCar()
    {
        Console.WriteLine($"Fuel Type:{FuelType}");
    }
}

class Program1
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Corolla";
        myCar.FuelType = "Petrol";

        myCar.DisplayVehical();

        myCar.DisplayCar();
    }
}