using System.Collections.Generic;
using BooksApiMongoDb.Entities;
using BooksApiMongoDb.Models;

namespace BooksApiMongoDb.Services
{
    public interface IBookService
    {
        List<Book> Get();
        Book Get(string id);
        Book Create(ViewBook book);
        void Update(string id, ViewBook bookIn);
        void UpdatePrice(string id, decimal price);
        void Remove(Book bookIn);
        void Remove(string id);
    }
}