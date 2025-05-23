using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;

class Program
{
    static bool pause = false;
    static bool stop = false;

    static void DoWork()
    {
        while (!stop)
        {
            if (pause)
            {
                Console.WriteLine("Thread paused...");
                Thread.Sleep(500);
                continue;
            }

            Console.WriteLine("Thread is working...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Thread has stopped.");
    }

    static void Main()
    {
        Thread worker = new Thread(DoWork);

        Console.WriteLine("Initial Thread state: " + worker.ThreadState);
        worker.Start();

        Thread.Sleep(3000);
        pause = true;
        Console.WriteLine("Paused Thread State: " + worker.ThreadState);

        Thread.Sleep(3000);
        pause = false;
        Console.WriteLine("Resumingwork...");

        Thread.Sleep(3000);
        stop = true;
        Console.WriteLine("Stopping thread...");

        worker.Join();
        Console.WriteLine("Final Thread State: " + worker.ThreadState);
    }
}

/*

Output:

Initial Thread state: Unstarted
Thread is working...
Thread is working...
Thread is working...
Paused Thread State: WaitSleepJoin
Thread paused...
Thread paused...
Thread paused...
Thread paused...
Thread paused...
Thread paused...
Resumingwork...
Thread is working...
Thread is working...
Thread is working...
Stopping thread...
Thread has stopped.
Final Thread State: Stopped

*/