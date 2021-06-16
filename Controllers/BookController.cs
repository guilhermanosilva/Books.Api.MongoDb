using BooksApiMongoDb.Entities;
using BooksApiMongoDb.Models;
using BooksApiMongoDb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BooksApiMongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>List of all registered books</summary>
        /// <remarks>Case empty returns: [ ] </remarks>
        /// <response code="200">List of all registered books</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public ActionResult<List<Book>> Get() =>
            _bookService.Get();
  
        /// <summary>Return book by Id</summary>
        /// <param name="id">String id with 24 digits</param>
        /// <response code="200">Returns find book</response>
        /// <response code="404">Not found a book for the id passed</response> 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id:length(24)}")]
        public ActionResult<Book> Get(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        /// <summary>Insert new book</summary>
        /// <param name="book">Object JSON</param>
        /// <response code="201">Created</response>
        /// <response code="400">Error in some registration value</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Book> Create(ViewBook book)
        {
            var bookCreated = _bookService.Create(book);

            return CreatedAtAction(nameof(Get), new { id = bookCreated.Id.ToString() }, bookCreated);
        }

        /// <summary>Update all existing book data</summary>
        /// <param name="id">String id with 24 digits</param>
        /// <param name="bookIn">Book data to be updated</param>
        /// <response code="204">Successfully updated</response>
        /// <response code="404">Not found a book for the id passed</response> 
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, ViewBook bookIn)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Update(id, bookIn);

            return NoContent();
        }

        /// <summary>Delete book by Id</summary>
        /// <param name="id">String id with 24 digits</param>
        /// <response code="204">Successfully deleted</response>
        /// <response code="404">Not found a book for the id passed</response> 
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(book.Id);

            return NoContent();
        }
    }
}