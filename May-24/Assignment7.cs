/*

Exercise 7: Sequential vs Parallel Execution Time
•	Create SimulateWorkAsync(string name, int delay)
•	First run 3 of them sequentially using await one after another.
•	Then run all using Task.WhenAll().
•	Compare total time taken for both runs using Stopwatch.

*/

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed.");
    }

    static async Task Main()
    {
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        await SimulateWorkAsync("Task1", 2000);
        await SimulateWorkAsync("Task2", 2000);
        await SimulateWorkAsync("Task3", 2000);
        stopwatch.Stop();
        Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");

        stopwatch.Restart();
        Task t1 = SimulateWorkAsync("Task1", 2000);
        Task t2 = SimulateWorkAsync("Task2", 2000);
        Task t3 = SimulateWorkAsync("Task3", 2000);
        await Task.WhenAll(t1, t2, t3);
        stopwatch.Stop();
        Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
    }
}

/*

Output:

Task1 started.
Task1 completed.
Task2 started.
Task2 completed.
Task3 started.
Task3 completed.
6047 ms
Task1 started.
Task2 started.
Task3 started.
Task3 completed.
Task2 completed.
Task1 completed.
2013 ms

*/