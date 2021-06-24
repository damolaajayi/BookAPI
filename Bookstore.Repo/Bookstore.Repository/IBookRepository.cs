using Bookstore.Core.Models;
using MongoDB.Driver;

namespace Bookstore.Repository
{
    public interface IBookRepository
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}
