using System.Collections.Generic;
using BooksApiMongoDb.Models;

namespace BooksApiMongoDb.Repositories
{
    public interface IMongoRepository
    {
        List<Book> Get();
        Book Get(string id);
        Book Create(Book book);
        void Update(string id, Book bookIn);
        void Remove(Book bookIn);
        void Remove(string id);
    }
}