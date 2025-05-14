using System;
interface IBankAccount
{
    void Deposite(double amoount);
    void WithDraw(double amount);
    void CheckBalance();
}
class SavingsAccount : IBankAccount
{
    public void Deposite(double amount)
    {
        Console.WriteLine($"Deposite {amount} rupees to your account");
    }
    public void WithDraw(double amount)
    {
        Console.WriteLine($"WithDraw total {amount} from your account");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Please check the balance in your account");
    }
}


class CurrentAccount : IBankAccount
{
    public void Deposite(double amount)
    {
        Console.WriteLine($"Deposite {amount} rupees to your current account");
    }
    public void WithDraw(double amount)
    {
        Console.WriteLine($"Withdraw total {amount} from your current account");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Check the balancein your current account");
    }
}

class Program3
{
    static void Main()
    {
        IBankAccount sa = new SavingsAccount();
        IBankAccount ca = new CurrentAccount();

        sa.Deposite(75000.00);
        sa.WithDraw(65000);
        sa.CheckBalance();

        ca.Deposite(89000.00);
        ca.WithDraw(4500.00);
        ca.CheckBalance();
    }
}