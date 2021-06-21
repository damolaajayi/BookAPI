using Bookstore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.AppService
{
    public interface IBookServices
    {
        List<Book> GetBooks();
    }
}
