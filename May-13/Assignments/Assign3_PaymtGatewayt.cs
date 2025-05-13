using System;

abstract class PaymentGateway
{ 
    public void ShowGateWayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }

    //abstract method
    public abstract void ProcessPayment(double amount);
}

class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through Stripe:{amount}");
    }
}

class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through PaiPal:{amount}");
    }
}
class Program
{
    static void Main()
    {
        PaymentGateway stripe=new StripeGateway();
        PaymentGateway paypal=new PayPalGateway();

        stripe.ShowGateWayName();
        stripe.ProcessPayment(150.75);

        paypal.ShowGateWayName() ;
        paypal.ProcessPayment(89.99);
    }
}