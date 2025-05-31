/*

6. Library Management System (OOP + Collections)
Concepts: Class structure, object list management Task:
Classes: Book , Student
Add, delete, and borrow books
Track who borrowed what and due dates.

*/

using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; } 

    public string Title { get; set; }

    public bool IsBorrowed { get; set; }

    public DateTime? DueDate { get; set; }

    public Book(int id,string title)
    {
        Id = id;
        Title = title;
        IsBorrowed = false;
        DueDate = null;
    }
}

class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Book> BorrowedBooks { get; set; } = new List<Book>();

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void BorrowBook(Book book)
    {
        if (!book.IsBorrowed)
        {
            book.IsBorrowed = true;
            book.DueDate = DateTime.Now.AddDays(14);
            BorrowedBooks.Add(book);
            Console.WriteLine($"{Name} borrowed \"{ book.Title}\" (Due Date:{book.DueDate?.ToShortDateString()})" );
        }
        else
        {
            Console.WriteLine($"Sorry,\"{book.Title}\" is already borrowed.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Remove(book))
        {
            book.IsBorrowed = false;
            book.DueDate = null;
            Console.WriteLine($"{Name} returned \"{book.Title}\"");
        }
        else
        {
            Console.WriteLine($"{Name} did not borrow \"{book.Title}\"");
        }
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book) => books.Add(book);
    public void RemoveBook(Book book) => books.Remove(book);

    public void DisplayBooks()
    {
        Console.WriteLine("\nAvailable Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID:{book.Id},Title:{book.Title},Borrowed:{book.IsBorrowed},Due Date:{ book.DueDate?.ToShortDateString()?? "Available"}");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        Student student = new Student(1, "Cherry");

        Book book1 = new Book(101, "C# Programming");
        Book book2 = new Book(102, "Python Programming");

        library.AddBook(book1);
        library.AddBook(book2);
        library.DisplayBooks();

        student.BorrowBook(book1);
        library.DisplayBooks();

        student.ReturnBook(book1);
        library.DisplayBooks();
    }
}
