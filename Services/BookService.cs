using System.Collections.Generic;
using BooksApiMongoDb.Models;
using BooksApiMongoDb.Repositories;

namespace BooksApiMongoDb.Services
{
    public class BookService : IBookService
    {
        private readonly IMongoRepository _repository;
        
        public BookService(IMongoRepository repository)
        {
            _repository = repository;
        }

        public List<Book> Get() =>
            _repository.Get(); 
            // .Find(book => true).ToList();

        public Book Get(string id) =>
            _repository.Get(id);
            // _books.Find<Book>(book => book.Id == id).FirstOrDefault();


        public Book Create(ViewBook bookIn)
        {
            var book = new Book{
                Author = bookIn.Author,
                BookName = bookIn.BookName,
                Dimensions = bookIn.Dimensions,
                Editor = bookIn.Editor,
                ISBN = bookIn.ISBN,
                Language = bookIn.Language,
                Price = bookIn.Price
            };
            _repository.Create(book);
            // _books.InsertOne(book);
            return book;
        }

        public void Update(string id, ViewBook bookIn)
        {
            var bookUpdated = new Book{
                Id = id,
                Author = bookIn.Author,
                BookName = bookIn.BookName,
                Dimensions = bookIn.Dimensions,
                Editor = bookIn.Editor,
                ISBN = bookIn.ISBN,
                Language = bookIn.Language,
                Price = bookIn.Price
            };

            _repository.Update(id, bookUpdated);
            // _books.ReplaceOne(book => book.Id == id, bookUpdated);
        }

        public void Remove(Book bookIn) =>
            _repository.Remove(bookIn);
            // _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _repository.Remove(id);
            // _books.DeleteOne(book => book.Id == id);
    }
}