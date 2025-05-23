
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void DoWork(object state)
    {
        Console.WriteLine($"ThreadPool Task Started - {state}");
        Thread.Sleep(1000);
        Console.WriteLine($"ThreadPool Task Finished - {state}");
    }

    static void Main()
    {
        for (int i = 1; i<=5;i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, $"Task {i}");
        }

        Console.WriteLine("Main thread continues...");
        Thread.Sleep(3000);
        Console.WriteLine("Main thread ends.");
    }
}

/*

Output:

Main thread continues...
ThreadPool Task Started - Task 4
ThreadPool Task Started - Task 3
ThreadPool Task Started - Task 2
ThreadPool Task Started - Task 1
ThreadPool Task Finished - Task 3
ThreadPool Task Started - Task 5
ThreadPool Task Finished - Task 1
ThreadPool Task Finished - Task 2
ThreadPool Task Finished - Task 4
ThreadPool Task Finished - Task 5
Main thread ends.

*/


