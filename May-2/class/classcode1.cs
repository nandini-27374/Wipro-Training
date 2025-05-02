using System;

class Program
{
    static int LinearSearch(int[] arr,int target)
    {
        for (int i=0;i<arr.Length;i++)
        {
            if (arr[i] == target)
                return i; //return index where target is found
        }
        return -1;
    }
    static void Main()
    {
        int[] numbers ={10,25,30,45,60,75};
        int target=45;
        
        int result=LinearSearch(numbers,target);
        
        if (result != -1)
            Console.WriteLine($"Element {target} found in the array");
        else
            Console.WriteLine($"Element {target} not found in the array");
    }
}