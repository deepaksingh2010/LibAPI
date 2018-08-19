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
    public class BookTypeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetBookTypeByID(int id)
        {
            BookTypeRepository ctxBookType = new BookTypeRepository();

            BookType _BookType = ctxBookType.GetBookType().FirstOrDefault(x => x.BookTypeID == id);

            if (_BookType != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _BookType);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllBookTypes()
        {
            BookTypeRepository ctxBookType = new BookTypeRepository();
            IEnumerable<BookType> lsBookTypes;

            lsBookTypes = ctxBookType.GetBookType();
            if (lsBookTypes.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsBookTypes);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddBookType([FromBody]BookType _BookType)
        {
            BookTypeRepository ctxBookType = new BookTypeRepository();
            ctxBookType.InsertBookType(_BookType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookType.BookTypeID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateBookType([FromBody]BookType _BookType)
        {
            BookTypeRepository ctxBookType = new BookTypeRepository();
            ctxBookType.UpdateBookType(_BookType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookType.BookTypeID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBookType(int id)
        {
            BookTypeRepository ctxBookType = new BookTypeRepository();
            ctxBookType.DeleteBookType(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}