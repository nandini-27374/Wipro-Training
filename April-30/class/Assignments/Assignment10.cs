using System;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 3, 2, 4, 1 };
        int[] uniqueArray = new int[originalArray.Length];
        int uniqueCount = 0;

        for (int i = 0; i < originalArray.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (originalArray[i] == uniqueArray[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                uniqueArray[uniqueCount] = originalArray[i];
                uniqueCount++;
            }
        }

        Console.WriteLine("Array without duplicates:");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(uniqueArray[i] + " ");
        }
    }
}