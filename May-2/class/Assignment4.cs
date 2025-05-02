using System;
class Program
{
    static int SumDigits(int number)
    {
        if (number == 0)
            return 0;
        return (number % 10) + SumDigits(number / 10);
    }
    static int SumDigitsInArray(int[] arr, int index)
    {
        if (index == arr.Length) 
            return 0;

        return SumDigits(arr[index]) + SumDigitsInArray(arr, index + 1);
    }

    static void Main()
    {
        int[] numbers = { 1, 3, 5 };
        int total = SumDigitsInArray(numbers, 0);

        Console.WriteLine("Sum of all digits in the array: " + total);
    }
}
