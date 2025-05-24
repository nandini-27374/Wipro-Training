/*

Exercise 2: Create Multiple Threads and Use Join
•	Create 3 threads that simulate independent tasks (like printing, computing, or waiting).
•	Start all threads and use Join() to wait for all to complete before printing “All tasks done”.

*/

using System;
using System.Threading;

class Program
{
    static void Printing()
    {
        Console.WriteLine($"Printing thread is complted.");
    }

    static void Computing()
    {
        Console.WriteLine($"Computing thread is complted.");
    }

    static void Waiting()
    {
        Console.WriteLine($"Waiting threadis complted.");
    }

    static void Main()
    {
        Thread p1 = new Thread(() => Printing());
        Thread c1 = new Thread(() => Computing());
        Thread w1 = new Thread(() => Waiting());

        p1.Start();
        p1.Join();

        c1.Start();
        c1.Join();

        w1.Start();
        w1.Join();

        Console.WriteLine("All tasks done");

    }
}

/*

Output:

Printing thread is complted.
Computing thread is complted.
Waiting threadis complted.
All tasks done

*/

