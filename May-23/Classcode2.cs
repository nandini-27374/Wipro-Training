/* Parameterized thread
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void PrintMessage(object message)
    {
        string msg =(string)message;
        Console.WriteLine("Message: "+ msg);
    }

    static void Main()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        thread.Start("Hello from the thread");
    }
}

/*

Output:

Message: Hello from the thread

*/