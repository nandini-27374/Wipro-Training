// Threading example problem


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i=1;i<=5;i++)
        {
            Console.WriteLine($"thread: {i}");
            Thread.Sleep(500);
        }
    }
    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers);
        myThread.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500);
        }
    }
}

/*

Output:

Main: 1
thread: 1
thread: 2
Main: 2
Main: 3
thread: 3
Main: 4
thread: 4
thread: 5
Main: 5

*/