class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;
    void DisplayInfo()
    {


        Console.WriteLine($"Book information");
        Console.WriteLine($"--------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");

    }
    static void Main(string[] args )
    {
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12456670";
        book.NoOfPages = 200;


        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "899876670";
        book2.NoOfPages = 50;


        book.DisplayInfo();
        book2.DisplayInfo();

    }
}
