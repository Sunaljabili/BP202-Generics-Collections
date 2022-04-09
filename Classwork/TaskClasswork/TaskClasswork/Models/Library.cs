using System;
using System.Collections.Generic;
using System.Text;
using TaskClasswork.Exceptions;

namespace TaskClasswork.Models
{
    public class Library
    {

        public int BookLimit { get; set; }

        public List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            if (books.Count<BookLimit)
            {
                books.Add(book);

            }
            else
            {
                throw new CapacityLimitException("Limiti ashdiniz");
            }

        }

        public Book GetBookId(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bele kitab yoxdur");
            }

            foreach (var item in books)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bele kitab yoxdur");
            }
            foreach (var item in books)
            {
                if (item.Id==id)
                {
                    books.Remove(item);
                    return;
                }
            }

            throw new NotFoundException("Bele bir kitab tapilmadi");

           
        }
    }
}
