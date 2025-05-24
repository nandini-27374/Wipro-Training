/*

Exercise 4: Simulate Parallel Downloads
•	Create DownloadFileAsync(string fileName, int delay)
•	Simulate downloading 3 files in parallel.
•	Use Task.WhenAll() to await them and print total download time.

*/

using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay(delay); 
        Console.WriteLine($"Completed download: {fileName}");
    }

    static async Task Main()
    {
        var stopwatch = Stopwatch.StartNew();

        Task task1 = DownloadFileAsync("File1.txt", 2000); 
        Task task2 = DownloadFileAsync("File2.txt", 3000); 
        Task task3 = DownloadFileAsync("File3.txt", 1000); 

        await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();
        Console.WriteLine($"All downloads completed in {stopwatch.ElapsedMilliseconds} ms.");
    }
}

/*

Output:

Starting download: File1.txt
Starting download: File2.txt
Starting download: File3.txt
Completed download: File3.txt
Completed download: File1.txt
Completed download: File2.txt
All downloads completed in 3029 ms.

*/