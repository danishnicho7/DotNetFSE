using System;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {BookId}, Title: {Title}, Author: {Author}");
    }
}

class LibrarySearch
{
    public static Book LinearSearch(Book[] books, string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return book;
        }
        return null;
    }

    public static Book BinarySearch(Book[] sortedBooks, string title)
    {
        int left = 0;
        int right = sortedBooks.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int cmp = string.Compare(sortedBooks[mid].Title, title, StringComparison.OrdinalIgnoreCase);
            if (cmp == 0)
                return sortedBooks[mid];
            else if (cmp < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}

class Program
{
    static void Main()
    {
        Book[] books = {
            new Book(1, "Data Structures", "Mark Allen"),
            new Book(2, "C# Programming", "John Smith"),
            new Book(3, "Algorithms", "Robert Sedgewick")
        };

        Console.WriteLine("🔍 Linear Search for 'C# Programming':");
        Book linear = LibrarySearch.LinearSearch(books, "C# Programming");
        linear?.Display();

        Array.Sort(books, (x, y) => x.Title.CompareTo(y.Title)); 

        Console.WriteLine("\n🔍 Binary Search for 'Algorithms':");
        Book binary = LibrarySearch.BinarySearch(books, "Algorithms");
        binary?.Display();
    }
}
