using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Work started.");

        await DoAsyncWork();

        Console.WriteLine("Work completed.");
    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine("Working asynchronously...");
        await Task.Delay(2000);
        Console.WriteLine("Async work done.");
    }
}

/*

Output:

Work started.
Working asynchronously...
Async work done.
Work completed.

*/