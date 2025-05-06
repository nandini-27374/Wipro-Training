class program
{
    static void Main()
    {
        int number = 1234;
        int sum = 0;

        while (number !=0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        Console.WriteLine(sum);
    }
}