using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Think which shape you want to draw.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Program
{
    static void Main()
    {
        Shape shape=new Shape();
        shape.Draw();//calls base method

        Circle circle = new Circle();
        circle.Draw();//calls overriden method

        //Polymorphism
        Shape sha_cir = new Circle();
        sha_cir.Draw();//Calls overridden method
    }
}