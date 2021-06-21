using Bookstore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.AppService
{
    public class BookServices : IBookServices
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "Test",
                    Price = 12.99
                }
            };
        }
    }
}
