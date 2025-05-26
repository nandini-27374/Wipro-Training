/*

8. async/await + Parallel.ForEachAsync – Batch Image Processing
Task:
Simulate processing 20 image files using Parallel.ForEachAsync .
Use await Task.Delay(200ms) per image to simulate processing.
Print progress percentage in the console.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var images = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            images.Add($"Image_{i}.jpg");
        }

        int total = images.Count;

        for (int i = 0; i < total; i++)
        {
            string image = images[i];

            await Task.Delay(200);

            double percent = ((i + 1) / (double)total) * 100;
            Console.WriteLine($"Processed {image} - {percent:F1}% complete");
        }

        Console.WriteLine("All images processed.");
    }
}

/*

Output:

Processed Image_1.jpg - 5.0 % complete
Processed Image_2.jpg - 10.0 % complete
Processed Image_3.jpg - 15.0 % complete
Processed Image_4.jpg - 20.0 % complete
Processed Image_5.jpg - 25.0 % complete
Processed Image_6.jpg - 30.0 % complete
Processed Image_7.jpg - 35.0 % complete
Processed Image_8.jpg - 40.0 % complete
Processed Image_9.jpg - 45.0 % complete
Processed Image_10.jpg - 50.0 % complete
Processed Image_11.jpg - 55.0 % complete
Processed Image_12.jpg - 60.0 % complete
Processed Image_13.jpg - 65.0 % complete
Processed Image_14.jpg - 70.0 % complete
Processed Image_15.jpg - 75.0 % complete
Processed Image_16.jpg - 80.0 % complete
Processed Image_17.jpg - 85.0 % complete
Processed Image_18.jpg - 90.0 % complete
Processed Image_19.jpg - 95.0 % complete
Processed Image_20.jpg - 100.0 % complete
All images processed.

*/