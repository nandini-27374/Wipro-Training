using System;
class Program
{
    static int CountZeros(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;

        if (arr[index] == 0)
            return 1 + CountZeros(arr, index + 1);
        else
            return CountZeros(arr, index + 1);
    }

    static void Main()
    {
        int[] numbers = { 0, 5, 3, 0, 7, 0 ,0 };

        int zeroCount = CountZeros(numbers, 0);

        Console.WriteLine("Number of zeros in the array: " + zeroCount);
    }
}
