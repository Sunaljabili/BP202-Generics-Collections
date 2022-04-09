using System;
using System.Collections.Generic;
using System.Text;
using TaskClasswork.Exceptions;

namespace TaskClasswork.Models
{
    public class Book : Product
    {

        public Book(string authorname,int pagecount,string name,double price):base(name,price)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public string AuthorName { get; set; }

        public int PageCount { get; set; }
        public override void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalIncome += Price;
            }
            else
            {
                throw new ProductCountIsZeroException("Mehsul qalmadi ");
            }
         
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id-{Id} Adi - {Name} Price - {Price}  Count - {Count}");
        }
    }
}
