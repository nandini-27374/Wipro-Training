using System;

class Function
    {
        static int Sum(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);
            Console.WriteLine(result);
        }
    }