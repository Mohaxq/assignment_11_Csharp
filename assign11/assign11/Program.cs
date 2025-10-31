namespace assign11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book("978-3-16-148410-0", "C# Programming",
                new string[] { "Alice Smith", "Bob Johnson" },
                new DateTime(2020, 5, 1), 49.99m);
            Book B2 = new Book("978-1-23-456789-0", "Advanced C#",
                new string[] { "Charlie Brown" },
                new DateTime(2021, 8, 15), 59.99m);
            List<Book> bookList = new List<Book> { B1, B2 };
            Console.WriteLine("Titles:");
            LibraryEngine.ProcessBooks(bookList, new BookDelegate(BookFunctions.GetTitle));
            Console.WriteLine("\nAuthors:");
            LibraryEngine.ProcessBooks(bookList, new BookDelegate(BookFunctions.GetAuthors));
            Console.WriteLine("\nPrices:");
            LibraryEngine.ProcessBooks(bookList, new BookDelegate(BookFunctions.GetPrice));
            Console.WriteLine("\nISBNs:");
            LibraryEngine.ProcessBooks(bookList, BookFunctions.GetISBN);
        }
    }
}
