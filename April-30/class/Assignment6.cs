using System;
class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i=4;i<arr.Length;i--)
        {
            Console.WriteLine($"Element {i} : {arr[i]}");
        }
    }
   static void Main()
   {
       int[] numbers= {10,20,30,40,50};
       PrintArray(numbers);
   }
}
