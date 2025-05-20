using System;

using System.Linq;

class SearchComparison
{
    public static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i=0;i<arr.Length;i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;

    }

    public static int BinarySearch(int[] arr,int key, out int comparisons)
    {
        int left=0,right=arr.Length-1;
        comparisons = 0;

        while(left<=right)
        {
            comparisons++;
            int mid = (left + right) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid+1;
            else
                right = mid-1;
        }
        return -1;
    }
    static void Main()
    {
        int[] arr = new int[50];
        Random rand = new Random();

        for (int i=0;i<arr.Length;i++)
        {
            arr[i] = rand.Next(1,201);
        }
        Array.Sort(arr);

        //random element
        int key = arr[rand.Next(arr.Length)];

        Console.WriteLine("Sorted List");

        Console.WriteLine(string.Join(",", arr));

        Console.WriteLine($"Searching element is:{key}");

        int LinearComparisions;
        int LinearPosition=LinearSearch(arr,key,out LinearComparisions);

        int BinaryComparisions;
        int BinaryPosition=BinarySearch(arr,key, out BinaryComparisions);

        Console.WriteLine("Linear Search:");
        Console.WriteLine($"Position is :{LinearPosition},Comparisions:{LinearComparisions}");

        Console.WriteLine("Binay Search:");
        Console.WriteLine($"Position is :{BinaryPosition},Comparisions:{BinaryComparisions}");

        //check for efficiency

        Console.WriteLine("\nEfficiency Comparision:");

        if (LinearComparisions > BinaryComparisions)
        {
            Console.WriteLine("Binary Search is more efficient than Linear Search");
        }
        else if (LinearComparisions < BinaryComparisions)
        {
            Console.WriteLine("Binary Search is less efficient than Linear Search");
        }
        else
            Console.WriteLine("Both searches perform equally here");
    }
}
/*

Output:

Sorted List
1,4,18,21,27,33,35,36,37,45,54,55,57,72,78,79,81,83,88,93,94,95,100,102,110,122,125,129,130,134,138,140,144,146,147,148,151,152,153,160,165,171,171,176,178,180,183,190,193,199
Searching element is:129
Linear Search:
Position is :27,Comparisions:28
Binay Search:
Position is :27,Comparisions:4

Efficiency Comparision:
Binary Search is more efficient than Linear Search
*/