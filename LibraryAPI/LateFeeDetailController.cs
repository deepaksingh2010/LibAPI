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
    public class LateFeeDetailController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetLateFeeDetailByID(int id)
        {
            LateFeeDetailsRepository ctxLateFeeDetails = new LateFeeDetailsRepository();

            LateFeeDetails _LibMemeberShip = ctxLateFeeDetails.GetLateFeeDetails().FirstOrDefault(x => x.LateFeeDetailID == id);

            if (_LibMemeberShip != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _LibMemeberShip);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllLateFeeDetails()
        {
            LateFeeDetailsRepository ctxLateFeeDetails = new LateFeeDetailsRepository();
            IEnumerable<LateFeeDetails> lsLateFeeDetails;

            lsLateFeeDetails = ctxLateFeeDetails.GetLateFeeDetails();
            if (lsLateFeeDetails.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsLateFeeDetails);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddLateFeeDetails([FromBody]LateFeeDetails _LateFeeDetails)
        {
            LateFeeDetailsRepository ctxLateFeeDetails = new LateFeeDetailsRepository();
            ctxLateFeeDetails.InsertLateFeeDetails(_LateFeeDetails);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LateFeeDetails.LateFeeDetailID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateLateFeeDetails([FromBody]LateFeeDetails _LateFeeDetails)
        {
            LateFeeDetailsRepository ctxLateFeeDetails = new LateFeeDetailsRepository();
            ctxLateFeeDetails.UpdateLateFeeDetails(_LateFeeDetails);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LateFeeDetails.LateFeeDetailID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteLateFeeDetails(int id)
        {
            LateFeeDetailsRepository ctxLateFeeDetails = new LateFeeDetailsRepository();
            ctxLateFeeDetails.DeleteLateFeeDetails(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}