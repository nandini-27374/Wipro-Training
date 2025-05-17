using System;

abstract class Document
{ 
    public void ShowDocumentType()
    {
        Console.WriteLine("Document Type:{Type}");
    }

    //abstract method
    public abstract void PrintContent();
}

class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }
}

class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF document");
    }
}
class Program
{
    static void Main()
    {
        Document wd = new WordDocument();
        Document pd = new PDFDocument();

        wd.ShowDocumentType();
        wd.PrintContent();

        pd.ShowDocumentType();
        pd.PrintContent();
    }
}