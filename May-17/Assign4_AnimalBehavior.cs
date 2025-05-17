using System;

abstract class Animal
{ 
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    //abstract method
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}
class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Eat();
        dog.MakeSound();

        cat.Eat();
        cat.MakeSound();
    }
}