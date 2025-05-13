using System;

namespace Linq_Practice._4.Delegate
{
    class SimpleDelegate
    {
        public delegate int SomeOperations(int i, int j);

        class Program5
        {
            static int Sum(int x,int y)
            {
                return x + y;
            }

            static void Main(string[] args)
            {
                SomeOperations add = Sum;

                int result = add(10, 20);
                Console.WriteLine(result);
            }
        }
    }
}



