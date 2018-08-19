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
    public class BookIssueStatusController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetBookIssueStatusByID(int id)
        {
            BookIssueStatusRepository ctxBookIssueStatus = new BookIssueStatusRepository();

            BookIssueStatus _BookIssueStatus = ctxBookIssueStatus.GetBookIssueStatus().FirstOrDefault(x => x.BookIssueStatusID == id);

            if (_BookIssueStatus != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _BookIssueStatus);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllBookIssueStatuss()
        {
            BookIssueStatusRepository ctxBookIssueStatus = new BookIssueStatusRepository();
            IEnumerable<BookIssueStatus> lsBookIssueStatuss;

            lsBookIssueStatuss = ctxBookIssueStatus.GetBookIssueStatus();
            if (lsBookIssueStatuss.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsBookIssueStatuss);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddBookIssueStatus([FromBody]BookIssueStatus _BookIssueStatus)
        {
            BookIssueStatusRepository ctxBookIssueStatus = new BookIssueStatusRepository();
            ctxBookIssueStatus.InsertBookIssueStatus(_BookIssueStatus);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookIssueStatus.BookIssueStatusID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateBookIssueStatus([FromBody]BookIssueStatus _BookIssueStatus)
        {
            BookIssueStatusRepository ctxBookIssueStatus = new BookIssueStatusRepository();
            ctxBookIssueStatus.UpdateBookIssueStatus(_BookIssueStatus);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_BookIssueStatus.BookIssueStatusID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteBookIssueStatus(int id)
        {
            BookIssueStatusRepository ctxBookIssueStatus = new BookIssueStatusRepository();
            ctxBookIssueStatus.DeleteBookIssueStatus(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}