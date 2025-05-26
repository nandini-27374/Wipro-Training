/*

3. Composition + File I/O – Bank Account Logger
Task:
Create BankAccount class with Deposit() and Withdraw() .
Store all transactions in a List<Transaction> .
Save and load transaction history from a .txt file.
Display summary on restart.

*/

using System;
using System.Collections.Generic;
using System.IO;

public class Transaction
{
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }

    public Transaction(DateTime date, string type, decimal amount)
    {
        Date = date;
        Type = type;
        Amount = amount;
    }

    public override string ToString() => $"{Date:yyyy-MM-dd HH:mm:ss}\t{Type}\t₹{Amount:F2}";
}

public class BankAccount
{
    public decimal Balance { get; private set; }
    public List<Transaction> Transactions { get; private set; }
    private readonly string _filePath;

    public BankAccount(string filePath)
    {
        _filePath = filePath;
        Transactions = new List<Transaction>();
        LoadTransactions();
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        Balance += amount;
        var transaction = new Transaction(DateTime.Now, "Deposit", amount);
        Transactions.Add(transaction);
        SaveTransaction(transaction);
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return;
        Balance -= amount;
        var transaction = new Transaction(DateTime.Now, "Withdraw", amount);
        Transactions.Add(transaction);
        SaveTransaction(transaction);
    }

    private void SaveTransaction(Transaction transaction)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{transaction.Date:yyyy-MM-dd HH:mm:ss},{transaction.Type},{transaction.Amount}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error saving transaction: {ex.Message}");
        }
    }

    private void LoadTransactions()
    {
        if (!File.Exists(_filePath)) return;

        try
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3 &&
                        DateTime.TryParse(parts[0], out DateTime date) &&
                        decimal.TryParse(parts[2], out decimal amount))
                    {
                        var transaction = new Transaction(date, parts[1], amount);
                        Transactions.Add(transaction);
                        Balance += parts[1] == "Deposit" ? amount : -amount;
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading transactions: {ex.Message}");
        }
    }

    public void DisplaySummary()
    {
        Console.WriteLine("\n--- Transaction Summary ---");
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
        Console.WriteLine($"Current Balance: {Balance:F2}");
    }
}

class Program
{
    static void Main()
    {
        string filePath = "transactions.txt";
        BankAccount account = new BankAccount(filePath);

        account.Deposit(5000);
        account.Withdraw(1500);
        account.Deposit(2000);

        account.DisplaySummary();
    }
}

/*

Output:


---Transaction Summary-- -
2025 - 05 - 26 10:06:55     Deposit ? 5000.00
2025 - 05 - 26 10:06:55     Withdraw ? 1500.00
2025 - 05 - 26 10:06:55     Deposit ? 2000.00
2025 - 05 - 26 10:07:37     Deposit ? 5000.00
2025 - 05 - 26 10:07:37     Withdraw ? 1500.00
2025 - 05 - 26 10:07:37     Deposit ? 2000.00
2025 - 05 - 26 15:35:01     Deposit ? 5000.00
2025 - 05 - 26 15:35:01     Withdraw ? 1500.00
2025 - 05 - 26 15:35:01     Deposit ? 2000.00
Current Balance: 16500.00

*/