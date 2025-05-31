/*

1. Vehicle Rental System (OOP + Inheritance + Interface)
Concepts: Classes, Inheritance, Interfaces, Polymorphism Task:
Base class: Vehicle
Subclasses: Car , Bike , Truck
Interface: IRentable with method Rent()
Display rent cost per day and allow renting multiple vehicles.

*/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

//Rentable interface
interface IRentable
{
    void Rent(int days);
    decimal GetRentalRate();
}

// Abstract base class 
abstract class Vehicle : IRentable
{
    public string Model { get; set; }

    public Vehicle(string model)
    {
        Model = model;
    }

    public abstract decimal GetRentalRate();

    public virtual void Rent(int days)
    {
        decimal totalCost = GetRentalRate() * days;
        Console.WriteLine($"{GetType().Name} ({Model}) rented for {days} day(s). Total cost: {totalCost}");
    }
}

class Car : Vehicle
{
    public Car(string model) : base(model) { }

    public override decimal GetRentalRate() => 1500; 
}

class Bike : Vehicle
{
    public Bike(string model) : base(model) { }

    public override decimal GetRentalRate() => 500; 
}

class Truck : Vehicle
{
    public Truck(string model) : base(model) { }

    public override decimal GetRentalRate() => 2500; 
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Hyundai i20"),
            new Bike("Bajaj Pulsar"),
            new Truck("Tata Ace")
        };

        List<(int vehicleIndex, int rentalDays)> rentalRequests = new List<(int, int)>
        {
            (0, 3), 
            (1, 2), 
            (2, 5)  
        };

        Console.WriteLine("Welcome to the Vehicle Rental System.\n");

        // Display available vehicles
        Console.WriteLine("Available Vehicles:");
        for (int i = 0; i < vehicles.Count; i++)
        {
            var vehicle = vehicles[i];
            Console.WriteLine($"{i + 1}. {vehicle.GetType().Name} - Model: {vehicle.Model}, Rental Rate per Day: {vehicle.GetRentalRate()}");
        }

        Console.WriteLine("\nProcessing Rental Requests...\n");

        // Process each rental request
        foreach (var request in rentalRequests)
        {
            int index = request.vehicleIndex;
            int days = request.rentalDays;

            if (index >= 0 && index < vehicles.Count && days > 0)
            {
                vehicles[index].Rent(days);
            }
            else
            {
                Console.WriteLine($"Invalid rental request for vehicle index {index + 1} with {days} days.");
            }
        }

        Console.WriteLine("\nThank you for using the Vehicle Rental System.");
    }
}

/*

Output:

Welcome to the Vehicle Rental System!

Available Vehicles:
1.Car - Model: Hyundai i20, Rental Rate per Day: 1500
2.Bike - Model: Bajaj Pulsar, Rental Rate per Day: 500
3.Truck - Model: Tata Ace, Rental Rate per Day: 2500

Processing Rental Requests...

Car (Hyundai i20) rented for 3 day(s). Total cost: 4500
Bike(Bajaj Pulsar) rented for 2 day(s). Total cost: 1000
Truck(Tata Ace) rented for 5 day(s). Total cost: 12500

Thank you for using the Vehicle Rental System!

*/