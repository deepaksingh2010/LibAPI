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
    public class BookIssuedController:ApiController
    {
        
        [HttpGet]
        public HttpResponseMessage GetBookIssuedByID(int id)
        {
            BookIssuedRepository ctxBookIssued = new BookIssuedRepository();

            BookIssued _BookIssued = ctxBookIssued.GetBookIssued().FirstOrDefault(x => x.BookIssuedID == id);

            if (_BookIssued != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _BookIssued);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllBookIssueds()
        {
            BookIssuedRepository ctxBookIssued = new BookIssuedRepository();
            IEnumerable<BookIssued> lsBookIssueds;

            lsBookIssueds = ctxBookIssued.GetBookIssued();
            if (lsBookIssueds.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsBookIssueds);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddBookIssued([FromBody]BookIssued _BookIssued)
        {
            BookIssuedRepository ctxBookIssued = new BookIssuedRepository();
            ctxBookIssued.InsertBookIssued(_BookIssued);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookIssued.BookIssuedID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateBookIssued([FromBody]BookIssued _BookIssued)
        {
            BookIssuedRepository ctxBookIssued = new BookIssuedRepository();
            ctxBookIssued.UpdateBookIssued(_BookIssued);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookIssued.BookIssuedID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBookIssued(int id)
        {
            BookIssuedRepository ctxBookIssued = new BookIssuedRepository();
            ctxBookIssued.DeleteBookIssued(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}