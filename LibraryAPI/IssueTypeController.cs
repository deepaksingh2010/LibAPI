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
    public class IssueTypeController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetIssueTypeByID(int id)
        {
            IssueTypeRepository ctxIssueType = new IssueTypeRepository();

            IssueType _IssueType = ctxIssueType.GetIssueType().FirstOrDefault(x => x.IssueTypeID == id);

            if (_IssueType != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IssueType);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllIssueTypes()
        {
            IssueTypeRepository ctxIssueType = new IssueTypeRepository();
            IEnumerable<IssueType> lsIssueTypes;

            lsIssueTypes = ctxIssueType.GetIssueType();
            if (lsIssueTypes.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsIssueTypes);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddIssueType([FromBody]IssueType _IssueType)
        {
            IssueTypeRepository ctxIssueType = new IssueTypeRepository();
            ctxIssueType.InsertIssueType(_IssueType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_IssueType.IssueTypeID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateIssueType([FromBody]IssueType _IssueType)
        {
            IssueTypeRepository ctxIssueType = new IssueTypeRepository();
            ctxIssueType.UpdateIssueType(_IssueType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_IssueType.IssueTypeID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteIssueType(int id)
        {
            IssueTypeRepository ctxIssueType = new IssueTypeRepository();
            ctxIssueType.DeleteIssueType(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}