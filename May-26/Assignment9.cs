/*

9. Exception Aggregation – Parallel Task Errors
Task:
Start 5 tasks using Task.WhenAll() .
Two of them should throw exceptions.
Catch AggregateException and log individual error messages.
Still show summary after all tasks complete.

*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var tasks = new List<Task>
        {
            Task.Run(() => Console.WriteLine("Task 1 completed.")),
            Task.Run(() => throw new InvalidOperationException("Task 2 failed.")),
            Task.Run(() => Console.WriteLine("Task 3 completed.")),
            Task.Run(() => throw new ArgumentException("Task 4 failed.")),
            Task.Run(() => Console.WriteLine("Task 5 completed."))
        };

        try
        {
            await Task.WhenAll(tasks);
        }
        catch
        {
            foreach (var task in tasks)
            {
                if (task.IsFaulted && task.Exception != null)
                {
                    foreach (var ex in task.Exception.InnerExceptions)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }
        finally
        {
            Console.WriteLine("All tasks have completed.");
        }
    }
}

/*

Output:

Task 1 completed.
Task 3 completed.
Task 5 completed.
Error: Task 2 failed.
Error: Task 4 failed.
All tasks have completed.

*/