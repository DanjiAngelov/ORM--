using System;
using System.Collections.Generic;
using System.Linq;

enum UserType { Обикновен, Специален, Златен }

class Book
{
    public string Title { get; set; }
    public List<string> Authors { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public int TimesTaken { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string title, List<string> authors, string genre, int year)
    {
        Title = title;
        Authors = authors;
        Genre = genre;
        Year = year;
        TimesTaken = 0;
    }
}

class User
{
    public string FullName { get; set; }
    public UserType Type { get; set; }
    public List<Book> TakenBooks { get; set; } = new();
    public List<Book> ReturnedBooks { get; set; } = new();

    public User(string fullName, UserType type)
    {
        FullName = fullName;
        Type = type;
    }

    public int GetBorrowDays()
    {
        return Type switch
        {
            UserType.Обикновен => 30,
            UserType.Специален => 35,
            UserType.Златен => 40,
            _ => 30
        };
    }
}

class Library
{
    public List<Book> Books { get; set; } = new();
    public List<User> Users { get; set; } = new();

    public void AddBook(Book book) => Books.Add(book);

    public void RemoveBook(Book book) => Books.Remove(book);

    public void BorrowBook(User user, string title)
    {
        var book = Books.FirstOrDefault(b => b.Title == title && b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = false;
            book.TimesTaken++;
            user.TakenBooks.Add(book);
        }
    }

    public void ReturnBook(User user, string title)
    {
        var book = user.TakenBooks.FirstOrDefault(b => b.Title == title);
        if (book != null)
        {
            book.IsAvailable = true;
            user.TakenBooks.Remove(book);
            user.ReturnedBooks.Add(book);
        }
    }

    public List<Book> Search(string? genre = null, string? author = null, int? year = null)
    {
        return Books.Where(b =>
            (genre == null || b.Genre == genre) &&
            (author == null || b.Authors.Contains(author)) &&
            (year == null || b.Year == year)
        ).ToList();
    }

    public Book? GetBookInfo(string title)
    {
        return Books.FirstOrDefault(b => b.Title == title);
    }

    public void GetUserInfo(User user)
    {
        Console.WriteLine($"Потребител: {user.FullName} ({user.Type})");
        Console.WriteLine("Взети книги: " + string.Join(", ", user.TakenBooks.Select(b => b.Title)));
        Console.WriteLine("Върнати книги: " + string.Join(", ", user.ReturnedBooks.Select(b => b.Title)));
    }
}
