using System.Runtime.InteropServices;

class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    //Constructor for book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages )
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;

    }


    void DisplayInfo()
    {
        //Output the book information to the console

        Console.WriteLine($"Book Information");
        Console.WriteLine($"----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of pages: {NoOfPages}");
        Console.WriteLine();
    }



    static void Main(string[] args)
    {
        //Create a new instance of the book class
        
        Book book = new Book("C# for beginners", "Bill Gates", "1234566", 200);



        //another instance?
        //title = "Visual Studio 2022"
        //Author = "Microsoft"
        //ISBN = "123"
        //No Of pages = 70
        Book book1 = new Book("Visual Sudio 2022", "Microsoft", "123", 70);


        //Output Book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();
   


    }
}
