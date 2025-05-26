/*

4. Thread with Dynamic Work Assignment
Task:
Start a thread that waits for work via a shared Queue<string> .
From Main() , enqueue 5 tasks while the thread runs.
Use lock to synchronize access to the queue.
Exit when all tasks are processed.

*/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static Queue<string> taskQueue= new Queue<string>();
    static readonly object queueLock = new object();
    static bool isRunning = true;

    static void Worker()
    {
        while (true)
        {
            string task = null;

            lock (queueLock)
            {
                if (taskQueue.Count >0)
                {
                    task = taskQueue.Dequeue();
                }
                else if (!isRunning)
                {
                    break;
                }
            }

            if (task != null)
            {
                Console.WriteLine($"Processing : {task}");
                Thread.Sleep(500);
            }
            else
            {
                Thread.Sleep(100);
            }
        }
        Console.WriteLine("Worker thread exiting.");
    }

    static void Main()
    {
        Thread workerThread = new Thread(Worker);   
        workerThread.Start();

        for (int i=1;i<=5;i++)
        {
            lock (queueLock)
            {
                taskQueue.Enqueue($"Task {i}");
            }
            Console.WriteLine($"Enqueued : Task{i}");
            Thread.Sleep(200);
        }

        lock (queueLock)
        {
            isRunning = false;
        }

        workerThread.Join();
        Console.WriteLine("All tasks processed.Main thread exiting.");
    }
}

/*

Output:

Enqueued: Task1
Processing : Task 1
Enqueued : Task2
Enqueued : Task3
Processing : Task 2
Enqueued : Task4
Enqueued : Task5
Processing : Task 3
Processing : Task 4
Processing : Task 5
Worker thread exiting.
All tasks processed.Main thread exiting.

*/