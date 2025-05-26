/*

1. Interface + Inheritance + Polymorphism – Payment Gateway System
Task:
Create an interface IPaymentProcessor with ProcessPayment() .
Create an abstract class PaymentGateway with GatewayName and a method
Validate() .
Implement Razorpay , PayPal , and Stripe classes.
Process multiple payments polymorphically from a list of IPaymentProcessor .

*/

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public abstract class PaymentGateway
{
    public string GatewayName { get; set; }

    public PaymentGateway(string gatewayName)
    {
        GatewayName = gatewayName;
    }

    public void Validate()
    {
        Console.WriteLine($"Validating payment through {GatewayName}...");
    }
}

public class Razorpay: PaymentGateway, IPaymentProcessor
{
    public Razorpay() : base("Razorpay") { }

    public void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing {amount} via Razorpay.");
    }
}

public class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal() : base("PayPal") { }

    public void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing {amount} via PayPaly.");
    }
}

public class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe() : base("Stripe") { }

    public void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing {amount} via Stripe.");
    }
}

public class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> processors = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe(),
        };

        decimal[] amounts = { 1000.0m, 2000.0m, 3000.0m };

        for (int i = 0; i < processors.Count; i++)
        {
            processors[i].ProcessPayment(amounts[i]);
            Console.WriteLine();
        }
    }
}

/*

Output:

Validating payment through Razorpay...
Processing 1000.0 via Razorpay.

Validating payment through PayPal...
Processing 2000.0 via PayPaly.

Validating payment through Stripe...
Processing 3000.0 via Stripe.

*/