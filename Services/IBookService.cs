using System.Collections.Generic;
using BooksApiMongoDb.Models;

namespace BooksApiMongoDb.Services
{
    public interface IBookService
    {
        List<Book> Get();
        Book Get(string id);
        Book Create(BookInput book);
        void Update(string id, BookInput bookIn);
        void Remove(Book bookIn);
        void Remove(string id);
    }
}