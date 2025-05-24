/*

Exercise 6: Use Task.WhenAny()
•	Create 3 tasks with different delays.
•	Use Task.WhenAny() to find which one finishes first and print its name.

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<string> DoWorkAsync(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }

    static async Task Main()
    {
        Task<string> task1 = DoWorkAsync("Task1", 3000);
        Task<string> task2 = DoWorkAsync("Task2", 2000);
        Task<string> task3 = DoWorkAsync("Task3", 1000);

        Task<string> firstCompletedTask = await Task.WhenAny(task1, task2, task3);

        string completedTaskName = await firstCompletedTask;

        Console.WriteLine($"{completedTaskName} completed first");

    }
}

/*

Output:

Task3 completed first

*/