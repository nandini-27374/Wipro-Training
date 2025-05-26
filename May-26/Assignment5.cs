/*

5. Async Task WhenAny – Fastest Server Simulation
Task:
Create 3 async methods simulating responses from different servers ( Server1 ,
Server2 , Server3 ) with random delay.
Use Task.WhenAny() to get the fastest.
Cancel the remaining using CancellationTokenSource .

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<string> ServerAsync(string serverName, CancellationToken token)
    {
        var rand = new Random();
        int delay = rand.Next(1000, 5000);

        try
        {
            await Task.Delay(delay, token);
            token.ThrowIfCancellationRequested();
            return $"{serverName} responded in {delay} ms";
        }
        catch (OperationCanceledException)
        {
            return $"{serverName} was cancelled.";
        }
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        var server1 = ServerAsync("Server1", token);
        var server2 = ServerAsync("Server2", token);
        var server3 = ServerAsync("Server3", token);

        var tasks= new[] {server1, server2, server3 };

        var completedTask= await Task.WhenAny(tasks);
        Console.WriteLine(await completedTask);

        cts.Cancel();

        try
        {
            await Task.WhenAll(tasks);
        }

        catch (OperationCanceledException)
        {
            //Expected exception for cancelled tasks
        }
    }
}

/*

Output:

Server3 responded in 1414 ms

*/