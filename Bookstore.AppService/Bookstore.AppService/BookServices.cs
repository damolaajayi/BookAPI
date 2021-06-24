using Bookstore.Core.Models;
using Bookstore.Repository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.AppService
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books;

        public BookServices(IBookRepository bookRepository)
        {
            _books = bookRepository.GetBooksCollection();
        }

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void DeleteBook(string id)
        {
            _books.DeleteOne(book => book._id == id);
        }

        public Book GetBook(string id) => _books.Find(book => book._id == id).First();

        public List<Book> GetBooks() => _books.Find(book => true).ToList();

        public Book UpdateBook(Book book)
        {
            GetBook(book._id);
            _books.ReplaceOne(b => b._id == book._id, book);
            return book;
        }
    }
}
