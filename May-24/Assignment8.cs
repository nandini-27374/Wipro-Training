
/*
 
Exercise 8: Exception Handling in Async Code
•	Create RiskyTaskAsync(string name) where one of them throws an exception.
•	Use try/catch around Task.WhenAll() and print which task failed.

*/

using System;
using System.Threading.Tasks;

class Program
{
    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(500);
        if (name == "Task2")
            throw new Exception($"{name} failed.");
        Console.WriteLine($"{name} completed.");
    }

    static async Task Main()
    {
        var t1 = RiskyTaskAsync("Task1");
        var t2 = RiskyTaskAsync("Task2");
        var t3 = RiskyTaskAsync("Task3");

        try
        {
            await Task.WhenAll(t1, t2, t3);
        }
        catch
        {
            Console.WriteLine("At least one task failed.");
        }
    }
}

/*

Output:

Task3 completed.
Task1 completed.
At least one task failed.

*/