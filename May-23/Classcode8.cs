using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all tasks...");

        Task task1 = DoWorkAsync("Task 1", 2000);
        Task task2 = DoWorkAsync("Task 2", 3000);
        Task task3 = DoWorkAsync("Task 3", 2000);

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("All tasks completed.");
    }
    static async Task DoWorkAsync(string name,int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed after {delay}ms.");
    }
}

/*

Output:

Starting all tasks...
Task 1 started.
Task 2 started.
Task 3 started.
Task 3 completed after 2000ms.
Task 1 completed after 2000ms.
Task 2 completed after 3000ms.
All tasks completed.

*/