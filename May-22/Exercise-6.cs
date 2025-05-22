/*

Use an animal hierarchy to demonstrate behavior and feeding logic.
Instructions:
1. Create abstract class Animal :
Properties: Name , Age
Abstract method: MakeSound()
Concrete method: Feed() => "Feeding the animal"

2. Create classes Lion , Elephant , Monkey
Each overrides MakeSound()
3. Create a Zoo class that holds a list of animals and invokes all actions.

*/

using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"Feeding the {Name}.");
    }
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars!");
    }
}

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets!");
    }
}

class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chatters!");
    }
}

class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void MakeAllSounds()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
    public void FeedAllAnimals()
    {
        foreach (var animal in animals)
        {
            animal.Feed();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion("Leo", 5));
        zoo.AddAnimal(new Elephant("Ella", 10));
        zoo.AddAnimal(new Monkey("Momo", 3));
        zoo.MakeAllSounds();

        zoo.FeedAllAnimals();
    }
}

/*

Output:

Leo roars!
Ella trumpets!
Momo chatters!
Feeding the Leo.
Feeding the Ella.
Feeding the Momo.

*/