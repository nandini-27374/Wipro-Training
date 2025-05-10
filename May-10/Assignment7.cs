sing System;

class Payment
{
    public string Currency;
    public decimal Amount;

    public void ProcessPayment()
    {
        Console.WriteLine($"{Amount} and {Currency}");
    }
}

class CreditCardPayment : Payment
{
    long CardNumber;

    public void ProcessPayment(decimal Amount,string Currency)
    {
        Console.WriteLine($"Amount :{Amount}");
        Console.WriteLine($"Currency is:{Currency}");
    }

    public void Card(long CardNumber)
    {
        Console.WriteLine($"Cardnumber: {CardNumber}");
    }
}

class PayPalPayment : Payment
{
    string EmailAddress;

    public void ProcessPayment(decimal Amount)
    {
        Console.WriteLine($"Amount: {Amount}");
    }

    public void Email(string EmailAddress)
    {
        Console.WriteLine($"Email :{EmailAddress}");
    }
}
public class Program3
{
    public static void Main(string[] args)
    {
        CreditCardPayment payment = new CreditCardPayment();    
        PayPalPayment payPalPayment = new PayPalPayment();


        payment.ProcessPayment(50000, "USD");
        payPalPayment.ProcessPayment(55000);
        payment.Amount = 6789;
        payment.Currency = "EUR";
        payment.ProcessPayment();
        payPalPayment.Email("user@gmail.com");
    }
}