using System;

abstract class PaymentMethod
{
    public void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method:" + this.GetType().Name);
    }

    //abstract method
    public abstract void ProcessPayment(decimal amount);
}

class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing CreditCardPayment of {amount}");
    }
}

class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of {amount}");
    }
}
class Program
{
    static void Main()
    {
        PaymentMethod ccp = new CreditCardPayment();
        PaymentMethod upip = new UPIPayment();

        ccp.ShowPaymentMethod();
        ccp.ProcessPayment(100.00m);

        Console.WriteLine();

        upip.ShowPaymentMethod();
        upip.ProcessPayment(300.00m);
    }
}