using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delayMs)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay(delayMs);
        Console.WriteLine($"Completed download:  {fileName} ({delayMs})");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all downloads...\n");

        Task file1 = DownloadFileAsync("file1.pdf", 3000);
        Task file2 = DownloadFileAsync("file2.jpg", 2000);
        Task file3 = DownloadFileAsync("file3.zip", 4000);

        await Task.WhenAll(file1, file2, file3);

        Console.WriteLine("\nAll downloads completed.");
    }
}

/*

Output:

Starting all downloads...

Starting download: file1.pdf
Starting download: file2.jpg
Starting download: file3.zip
Completed download: file2.jpg(2000)
Completed download:  file1.pdf(3000)
Completed download:  file3.zip(4000)

All downloads completed.

*/