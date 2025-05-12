interface IPayment
{
    void ProcessPayment(decimal amount);
}

class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processsing credit card payment of {amount}");
    }
}

class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

class Program1
{
    static void Main()
    {
        IPayment payment;

        payment = new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}