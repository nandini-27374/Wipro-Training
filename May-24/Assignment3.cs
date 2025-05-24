/*

Exercise 3: Use ThreadPool to Run Lightweight Tasks
•	Create a method ProcessItem(object item) that prints a message with a delay.
•	Use ThreadPool.QueueUserWorkItem to run this for 5 different items.

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void ProcessItem(object item)
    {
        Console.WriteLine($"ThreadPool Task Started - {item}");
        Thread.Sleep(1000);
        Console.WriteLine($"ThreadPool Task Finished - {item}");
    }

    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, $"Task {i}");
        }

        Console.WriteLine("Main thread continues...");
        Thread.Sleep(3000);
        Console.WriteLine("Main thread ends.");
    }
}

/*

Output:

Main thread continues...
ThreadPool Task Started - Task 1
ThreadPool Task Started - Task 2
ThreadPool Task Started - Task 3
ThreadPool Task Started - Task 4
ThreadPool Task Finished - Task 2
ThreadPool Task Started - Task 5
ThreadPool Task Finished - Task 1
ThreadPool Task Finished - Task 3
ThreadPool Task Finished - Task 4
ThreadPool Task Finished - Task 5
Main thread ends.

*/