using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPractice.Models.Concrete;

namespace WebApiPractice.Controllers
{
    public class BooksController : ApiController
    {
        private List<Book> _mockBooks = new List<Book>
        {
            new Book {Author = "Alexey Ivanov", Id = 1, Title = "Drunk geographer who sold the globe"},
            new Book {Author = "Sergey Ivanov", Id = 2, Title = "Another Drunk geographer who sold the globe"},
            new Book {Author = "Alefftina Ivanova", Id = 3, Title = "Drunk geographer revenge"}
        };

        [HttpGet]
        [Route("api/book/all")]
        public IEnumerable<Book> GetBooks()
        {
            return _mockBooks;
        }

        [HttpGet]
        [Route("api/book/{id}")]
        public Book GetBookById(int id)
        {
            return _mockBooks.FirstOrDefault(book => book.Id == id);
        }

        [HttpGet]
        [Route("api/book/getByTitle/{title}")]
        public Book GetByTitle(string title)
        {
            return _mockBooks.FirstOrDefault(book => book.Title == title);
        }

        [HttpPost]
        [Route("api/book/add")]
        public void AddBook([FromBody]Book book)
        {
            var maxBookNumber = _mockBooks.Max(b => b.Id);
            book.Id = ++maxBookNumber;
            _mockBooks.Add(book);
        }

        [HttpPut]
        [Route("api/book/update/{id}")]
        public void UpdateBook(int id, [FromBody]Book newBook)
        {
            Delete(id);
            _mockBooks.Add(newBook);
        }

        [HttpDelete]
        [Route("api/book/delete/{id}")]
        public void Delete(int id)
        {
            var deletingBook = _mockBooks.Find(b => b.Id == id);
            _mockBooks.Remove(deletingBook);
        }

    }
}