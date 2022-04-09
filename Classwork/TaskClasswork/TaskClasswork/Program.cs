using System;
using TaskClasswork.Exceptions;
using TaskClasswork.Models;

namespace TaskClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Zakir",300,"Sefiller",19.99);
            Book book2 = new Book("Hikmet", 200, "Hikmetin kitabi", 39.99);
            Book book3 = new Book("Abbas", 250, "Abbasin book-u ", 59.99);

            Library library = new Library();
            library.BookLimit = 2;
            try
            {
                //library.AddBook(book1);
                //library.AddBook(book2);
                //library.AddBook(book3);
                library.RemoveById(9);
                library.GetBookId(null);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
