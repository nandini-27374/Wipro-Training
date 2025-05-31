/*

Calculator App (Method Overloading)
Concepts: Overloading, Static methods Task:
Overload Add() , Subtract() , Multiply()
Different datatypes (int, float, double)
Take user input and dynamically call correct method.

*/

using System;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculator App ===");
        Console.WriteLine("Choose Operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.Write("Enter choice (1-3): ");
        string choice = Console.ReadLine();

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
        {
            PerformOperation(choice, int1, int2);
        }
        else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
        {
            PerformOperation(choice, float1, float2);
        }
        else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
        {
            PerformOperation(choice, double1, double2);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }

    static void PerformOperation(string choice, int a, int b)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "2":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "3":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Invalid operation choice.");
                break;
        }
    }

    static void PerformOperation(string choice, float a, float b)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "2":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "3":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Invalid operation choice.");
                break;
        }
    }

    static void PerformOperation(string choice, double a, double b)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "2":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "3":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Invalid operation choice.");
                break;
        }
    }
}

/*

Output:

=== Calculator App ===
Choose Operation:
1.Add
2.Subtract
3.Multiply
Enter choice(1-3): 3
Enter first number: 17
Enter second number: 9
Result: 153

*/