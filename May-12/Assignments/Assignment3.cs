using System;
interface IAnimalActions
{
    void Eat();
    void Sleep();
}
class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Lion is eating meat.");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }
}
class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep()
    {
        Console.WriteLine("Elephant is sleeping");
    }
}

class Program4
{
    static void Main()
    {
        Lion lione = new Lion();
        lione.Eat();
        Lion lionslp = new Lion();
        lionslp.Sleep();
        Elephant eleeat = new Elephant();
        eleeat.Eat();
        Elephant eleslp = new Elephant();
        eleslp.Sleep();
    }
}