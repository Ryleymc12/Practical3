class Book
{
    //properties (start with uppercase)
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // constructor for Book object (constructor must be called the class name or it wont work)
    // allows us to construct new books

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages )
    { 
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    
    }



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
        // create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "233342", 200);
        Book book2 = new Book("Visual Studio", "Microsoft", "233224", 70);
        

        book.DisplayInfo();
        book2.DisplayInfo();


    }
}
