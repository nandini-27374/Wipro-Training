/*

Create a mini-library that can search for books by author or title.
Instructions:
1. Create class Book : Id , Title , Author , IsAvailable
2. Create class Library with a List<Book>
3. Methods:
AddBook(Book book)
SearchByAuthor(string author)
SearchByTitle(string title)
4. In Main() , add sample books and perform both searches.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

class Book
{
    public int Id;
    public string Title;
    public string Author;
    public bool IsAvailable;

    public Book(int id, string title, string author, bool isAvailable = true)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        List<Book> result = new List<Book>();
        foreach (var book in books)
        {
            if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(book);
            }
        }
        return result;
    }

    public List<Book> SearchByTitle(string title)
    {
        List<Book> result = new List<Book>();
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(book);
            }
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddBook(new Book(2, "To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new Book(3, "1984", "George Orwell"));
        library.AddBook(new Book(4, "Animal Farm", "George Orwell"));

        Console.WriteLine("Search by Author: George Orwell");
        var booksByAuthor = library.SearchByAuthor("George Orwell");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
        }

        Console.WriteLine("\nSearch by Title: The Great Gatsby");
        var booksByTitle = library.SearchByTitle("The Great Gatsby");
        foreach (var book in booksByTitle)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
        }
    }
}

/*

Output:

Search by Author: George Orwell
Id: 3, Title: 1984, Author: George Orwell, Available: True
Id: 4, Title: Animal Farm, Author: George Orwell, Available: True

Search by Title: The Great Gatsby
Id: 1, Title: The Great Gatsby, Author: F.Scott Fitzgerald, Available: True

*/