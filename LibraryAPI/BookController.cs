using LibAPI;
using LibAPI.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace LibraryAPI
{
    public class BookController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetBookByID(int id)
        {
            BooksRepository ctxBook = new BooksRepository();

            Book _Book = ctxBook.GetBooks().FirstOrDefault(x => x.BookID == id);

            if (_Book != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _Book);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllBooks()
        {
            BooksRepository ctxBook = new BooksRepository();
            IEnumerable<Book> lsBooks;

            lsBooks = ctxBook.GetBooks();
            if (lsBooks.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsBooks);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddBook([FromBody]Book _Book)
        {
            BooksRepository ctxBook = new BooksRepository();
            ctxBook.InsertBook(_Book);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_Book.BookID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateBook([FromBody]Book _Book)
        {
            BooksRepository ctxBook = new BooksRepository();
            ctxBook.UpdateBook(_Book);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_Book.BookID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBook(int id)
        {
            BooksRepository ctxBook = new BooksRepository();
            ctxBook.DeleteBook(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}