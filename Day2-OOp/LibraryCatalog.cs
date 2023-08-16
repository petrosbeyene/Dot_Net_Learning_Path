using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("My Library", "1440 Hubbard, Ann Arbor, Michigan");

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-1234567890", 1945);
        Book book2 = new Book("To Kill a Mockingbird", "Shive Khera", "978-0987654321", 1963);

        MediaItem mediaItem1 = new MediaItem("Inception", "DVD", 148);
        MediaItem mediaItem2 = new MediaItem("Mother Nature", "CD", 65);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddMediaItem(mediaItem1);
        library.AddMediaItem(mediaItem2);

        library.PrintCatalog();
    }
}

class Library
{
    public string Name { get; }
    public string Address { get; }
    public List<Book> Books { get; } = new List<Book>();
    public List<MediaItem> MediaItems { get; } = new List<MediaItem>();

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
    }

    public void RemoveMediaItem(MediaItem item)
    {
        MediaItems.Remove(item);
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Catalog:");
        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Year: {book.PublicationYear}");
        }

        Console.WriteLine("Media Items:");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"Title: {item.Title}, Type: {item.MediaType}, Duration: {item.Duration} minutes");
        }
    }
}

class Book
{
    public string Title { get; }
    public string Author { get; }
    public string ISBN { get; }
    public int PublicationYear { get; }

    public Book(string title, string author, string isbn, int year)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
    }
}

class MediaItem
{
    public string Title { get; }
    public string MediaType { get; }
    public int Duration { get; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }
}
