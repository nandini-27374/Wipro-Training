using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 4 };

        for (int i=0;i<numbers.Length;i++)
        {
            bool counted = false;

            for (int j=0;j<i;j++)
            {
                if (numbers[i] == numbers[j])
                {
                    counted = true;
                    break;
                }
            }

            if (!counted)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(numbers[i] + " appears " + count + " time");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " appears " + count + " time");
                }
            }
        }
     }
}