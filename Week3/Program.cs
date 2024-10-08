using System.Runtime.InteropServices;

class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        //Output the book information to the console

        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
    }


    static void Main(string[] args)
    {
        //Create a new instance of the book class
        
        Book book = new Book();
        book.Title = "C# for begginers";
        book.Author = "Bill Gates";
        book.ISBN = "123456677";

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";

        //Output Book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();






    }
}
