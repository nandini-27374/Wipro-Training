using System;
using System.Collections.Generic;

// Book class
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Program
{
    static void Main()
    {
        //  Queue for borrowed books
        Queue<Book> borrowBooks = new Queue<Book>();
        borrowBooks.Enqueue(new Book("Book A", "Author Abhi"));
        borrowBooks.Enqueue(new Book("Book B", "Author Joshu"));
        borrowBooks.Enqueue(new Book("Book C", "Author Nikhil"));
        borrowBooks.Enqueue(new Book("Book D", "Author Anjali"));
        borrowBooks.Enqueue(new Book("Book E", "Author Madhu"));

        Console.WriteLine("Next book to return:");
        Book nextReturn = borrowBooks.Peek();
        Console.WriteLine($"{nextReturn.Title} by {nextReturn.Author}");

        Console.WriteLine("Returning the book...");
        borrowBooks.Dequeue();

        //  Stack for new purchases
        Stack<Book> newBooks = new Stack<Book>();
        newBooks.Push(new Book("New Book 1", "New Author Guna"));
        newBooks.Push(new Book("New Book 2", "New Author Devik"));
        newBooks.Push(new Book("New Book 3", "New Author Sashank"));

        Console.WriteLine("\nLast book purchased:");
        Book lastPurchased = newBooks.Peek();
        Console.WriteLine($"{lastPurchased.Title} by {lastPurchased.Author}");

        Console.WriteLine("Processing the new book...");
        newBooks.Pop();
    }
}
