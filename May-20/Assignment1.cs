using System;

class SortingComparison
{
    static void Main()
    {

        int[] original = new int[20];
        Random rand = new Random();
        for (int i = 0; i < original.Length; i++)
        {
            original[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Original Array:");
        PrintArray(original);


        int[] bubble = (int[])original.Clone();
        var watch = System.Diagnostics.Stopwatch.StartNew();
        BubbleSort(bubble);
        watch.Stop();
        Console.WriteLine("\nBubble Sort:");
        PrintArray(bubble);
        Console.WriteLine("Time: " + watch.ElapsedTicks + " ticks");

        int[] selection = (int[])original.Clone();
        watch.Restart();
        SelectionSort(selection);
        watch.Stop();
        Console.WriteLine("\nSelection Sort:");
        PrintArray(selection);
        Console.WriteLine("Time: " + watch.ElapsedTicks + " ticks");


        int[] insertion = (int[])original.Clone();
        watch.Restart();
        InsertionSort(insertion);
        watch.Stop();
        Console.WriteLine("\nInsertion Sort:");
        PrintArray(insertion);
        Console.WriteLine("Time: " + watch.ElapsedTicks + " ticks");


        Console.WriteLine("\nAll three sorts have O(n^2) time complexity.");
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}