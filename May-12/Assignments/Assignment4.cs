abstract class Book
{
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }

    //abstract method
    public abstract void Read();
}

class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}

class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}
class Program
{
    static void Main()
    {
        FictionBook fb = new FictionBook();
        fb.Read();
        ScienceBook sb = new ScienceBook();
        sb.Read();
    }
}