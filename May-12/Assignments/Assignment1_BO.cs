interface ICalculator
{
    int Add(int a, int b);
    int Subtraction(int a, int b);
    int Mul(int a, int b);
    double Divide(int a, int b);
}
class SimpleCalculator: ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
    public int Mul(int a, int b)
    {
        return a * b;
    }
    public double Divide(int a, int b)
    {
        return a / b;
    }
}

class Program1
{
    static void Main(string[] args)
    {
        ICalculator calc = new SimpleCalculator();

        Console.WriteLine("Add:" + calc.Add(10, 5));
        Console.WriteLine("Subtraction:" + calc.Subtraction(10, 5));
        Console.WriteLine("Multiplication:" + calc.Mul(10, 5));
        Console.WriteLine("Division:" + calc.Divide(10, 5));
    }
}