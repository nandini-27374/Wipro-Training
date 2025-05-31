/*

9. Async Weather Fetcher (async/await + Task.Delay)
Concepts: async/await, Task.WhenAll Task:
Simulate calling weather APIs for 3 cities
Use Task.Delay to mimic delay
Fetch all concurrently and print total time taken.

*/

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var stopwatch = Stopwatch.StartNew();

        var task1 = FetchWeatherAsync("Hyderabad", 2000);
        var task2 = FetchWeatherAsync("Mumbai", 3000);
        var task3 = FetchWeatherAsync("Delhi", 2500);

        await Task.WhenAll(task1,task2,task3);

        stopwatch.Stop();
        Console.WriteLine($"\nAll weather data fetched in {stopwatch.ElapsedMilliseconds} ms.");

    }

    static async Task FetchWeatherAsync(string city,int delay)
    {
        Console.WriteLine($"Fetching weather for {city}...");
        await Task.Delay(delay);
        Console.WriteLine($"Weather data for {city} received after {delay} ms.");
    }
}

/*

Output:

Fetching weather for Hyderabad...
Fetching weather for Mumbai...
Fetching weather for Delhi...
Weather data for Hyderabad received after 2000 ms.
Weather data for Delhi received after 2500 ms.
Weather data for Mumbai received after 3000 ms.

All weather data fetched in 3120 ms.

*/
