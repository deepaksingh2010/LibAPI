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
    public class BooksCategoryController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetBooksCategoryByID(int id)
        {
            BookCategoryRepository ctxBooksCategory = new BookCategoryRepository();

            BooksCategory _BooksCategory = ctxBooksCategory.GetBooksCategory().FirstOrDefault(x => x.BooksCategoryID == id);

            if (_BooksCategory != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _BooksCategory);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllBooksCategory()
        {
            BookCategoryRepository ctxBooksCategory = new BookCategoryRepository();
            IEnumerable<BooksCategory> lsBooksCategorys;

            lsBooksCategorys = ctxBooksCategory.GetBooksCategory();
            if (lsBooksCategorys.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsBooksCategorys);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddBooksCategory([FromBody]BooksCategory _BooksCategory)
        {
            BookCategoryRepository ctxBooksCategory = new BookCategoryRepository();
            ctxBooksCategory.InsertBooksCategory(_BooksCategory);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BooksCategory.BooksCategoryID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateBooksCategory([FromBody]BooksCategory _BookCategory)
        {
            BookCategoryRepository ctxBooksCategory = new BookCategoryRepository();
            ctxBooksCategory.UpdateBooksCategory(_BookCategory);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookCategory.BooksCategoryID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBooksCategory(int id)
        {
            BookCategoryRepository ctxBooksCategory = new BookCategoryRepository();
            ctxBooksCategory.DeleteBookCategory(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}