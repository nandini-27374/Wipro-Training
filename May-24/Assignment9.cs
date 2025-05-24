/*

Exercise 9: Cancellation Using CancellationToken
•	Create DoWorkAsync(CancellationToken token)
•	Cancel the task from Main() after 2 seconds.
•	Handle cancellation and print a message.

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            Console.WriteLine("Working...");
            await Task.Delay(500);
        }

        Console.WriteLine("Task was cancelled.");
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();

        var task = DoWorkAsync(cts.Token);

        await Task.Delay(2000); 
        cts.Cancel();           

        await task;             
    }
}

*/
