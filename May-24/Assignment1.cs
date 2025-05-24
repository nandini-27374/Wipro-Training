/*

Exercise 1: Start, Pause, Resume, and Stop a Thread
•	Create a thread that prints numbers from 1 to 100.
•	Use bool pause and bool stop flags to control the behavior.
•	From Main(), pause for a few seconds, resume, then stop the thread.
Use ThreadState to log status.

*/

using System;
using System.Threading;

class Program
{
    private static bool pause = false;
    private static bool stop = false;


    static void Main()
    {
        Thread workerThread = new Thread(PrintNumbers);
        workerThread.Start();
        Thread.Sleep(1000);
        Console.WriteLine("Pausing thread...");
        pause = true;

        Thread.Sleep(2000);
        Console.WriteLine("Resuming thread...");
        stop = true;

        workerThread.Join();
        Console.WriteLine("Worker thread has terminated.");
    }

    static void PrintNumbers()
    {
        int count = 1;
        while (stop && count <=100)
        {
            if (pause)
            {
                Console.WriteLine("Thread paused.");
                while(pause && stop)
                {
                    Thread.Sleep(500);
                }
                Console.WriteLine("Thread resumed.");
            }

            Console.WriteLine($"Count:{count}");
            count++;

            Console.WriteLine($"ThreadState:{Thread.CurrentThread.ThreadState}");

            Thread.Sleep(500);
        }
        Console.WriteLine("Thread stopping...");
    }
}

/*

Output:

Thread stopping...
Pausing thread...
Resuming thread...
Worker thread has terminated.

*/