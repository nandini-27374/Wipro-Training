/*

Exercise 5: Async Method Returning a Value
•	Create GetTemperatureAsync(string city) that returns a random temp after delay.
•	In Main(), call it for 3 cities and print the result.

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<int> GetTemperatureAsync(string city)
    {
        await Task.Delay(2000);

        int temperature;

        if (city == "Hyderabad")
            temperature = 30;
        else if (city == "Mumbai")
            temperature = 32;
        else if (city == "Delhi")
            temperature = 28;
        else
            temperature = 25;

        return temperature;
    }

    static async Task Main()
    {
        Task<int> tempTask1 = GetTemperatureAsync("Hyderabad");
        Task<int> tempTask2 = GetTemperatureAsync("Mumbai");
        Task<int> tempTask3 = GetTemperatureAsync("Delhi");

        int[] temperatures = await Task.WhenAll(tempTask1, tempTask2, tempTask3);

        Console.WriteLine($"Hyderabad:{temperatures[0]} C");
        Console.WriteLine($"Mumbai:{temperatures[0]} C");
        Console.WriteLine($"Delhi:{temperatures[0]} C");
    }
}

/*

Output:

Hyderabad: 30 C
Mumbai:30 C
Delhi:30 C

*/