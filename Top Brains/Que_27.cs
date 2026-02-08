using System;
using System.Collections.Generic;
class Books
{
    public string Name { get; set; }
    public string Publisher { get; set; }
    public double Price { get; set; }
}

class Admin
{
    public static void AddBook(string name, string publisher, double price)
    {
        dynamic book = new Books()
        {
            Name = name,
            Publisher = publisher,
            Price = price
        };

        Que_27.bookRecord.Add(book);
        Console.WriteLine("Book Added Successfully");
    }

    public static void DeleteBook(string name)
    {
        int removed = Que_27.bookRecord.RemoveAll(b => b.Name == name);

        if (removed > 0)
            Console.WriteLine("Book removed Successfully");
        else
            Console.WriteLine("Book not found!");
    }

    public static void ViewAllBooks()
    {
        if (Que_27.bookRecord.Count == 0)
        {
            Console.WriteLine("No Books Available");
            return;
        }

        foreach (var item in Que_27.bookRecord)
        {
            Console.WriteLine($"Name: {item.Name}, Publisher: {item.Publisher}, Price: {item.Price}");
        }
    }
}

class User
{
    public static void BrowseBooks()
    {
        if (Que_27.bookRecord.Count == 0)
        {
            Console.WriteLine("No Books Available");
            return;
        }

        int count = 1;
        foreach (var item in Que_27.bookRecord)
        {
            Console.WriteLine($"{count}. {item.Name}");
            count++;
        }
    }

    public static void HighestPriceBook()
    {
        if (Que_27.bookRecord.Count == 0)
        {
            Console.WriteLine("No Books Found");
            return;
        }

        var highest = Que_27.bookRecord[0];

        foreach (var item in Que_27.bookRecord)
        {
            if (item.Price > highest.Price)
                highest = item;
        }

        Console.WriteLine($"Highest Price Book: {highest.Name} - {highest.Price}");
    }

    public static void LowestPriceBook()
    {
        if (Que_27.bookRecord.Count == 0)
        {
            Console.WriteLine("No Books Found");
            return;
        }

        var lowest = Que_27.bookRecord[0];

        foreach (var item in Que_27.bookRecord)
        {
            if (item.Price < lowest.Price)
                lowest = item;
        }

        Console.WriteLine($"Lowest Price Book: {lowest.Name} - {lowest.Price}");
    }
}

class Que_27
{
    public static List<dynamic> bookRecord { get; set; } = new List<dynamic>();

    public static void main()
    {
        while (true)
        {
            Console.WriteLine("\n1 - Admin");
            Console.WriteLine("2 - User");
            Console.WriteLine("3 - Exit");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Admin.AddBook("Pride and Prejudice", "Jane Austen", 279);
                    Admin.AddBook("Helen Keller", "Helen Keller", 590);
                    Admin.AddBook("Gulliver's Travels", "Jonathan Swift", 1080);
                    Admin.ViewAllBooks();
                    break;

                case 2:
                    User.BrowseBooks();
                    User.HighestPriceBook();
                    User.LowestPriceBook();
                    break;

                case 3:
                    Console.WriteLine("Exiting Application...");
                    return;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}