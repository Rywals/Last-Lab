using System;

namespace Last_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "rrnichols@crimson.ua.edu");
            Console.WriteLine(myAuthor.ToStringAuthor());
            
            Book myBook = new Book("12234", "myBook, YourBook", myAuthor);
            Console.WriteLine(myBook.ToStringBook());

            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@email.com"));
            Console.WriteLine(yourBook.ToStringBook());
        }
    }
}
