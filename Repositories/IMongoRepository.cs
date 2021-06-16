using System.Collections.Generic;
using BooksApiMongoDb.Entities;

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
        void UpdatePrice(string id, decimal price);
    }
}