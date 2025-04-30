using System;
class Program
{
    static void PrintArray(int[] arr)
    {
        int num=30;
        for (int i=0;i < arr.Length;i++)
        {
            if (num == arr[i])
            {
                Console.WriteLine($"{num} is found at the index {i}");
                return;
            }
        }
        Console.WriteLine("number not found");
    }
   static void Main()
   {
       int[] numbers= {10,20,30,40,50};
       PrintArray(numbers);
   }
}
