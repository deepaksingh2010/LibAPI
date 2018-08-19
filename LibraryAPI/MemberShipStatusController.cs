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
    public class MemberShipStatusController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetMemberShipStatusByID(int id)
        {
            MemberShipStatusRepository ctxMemberShipStatuses = new MemberShipStatusRepository();
            MemberShipStatus _MemberShipStatus;

            _MemberShipStatus = ctxMemberShipStatuses.GetMemberShipStatus().FirstOrDefault(x => x.MembershipstatusID == id);

            if (_MemberShipStatus!= null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _MemberShipStatus);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllMemberShipStatuses()
        {
            MemberShipStatusRepository MemberShipStatuses = new MemberShipStatusRepository();
            List<MemberShipStatus> lsMemberShipStatuses;

            lsMemberShipStatuses = MemberShipStatuses.GetMemberShipStatus();
            if (lsMemberShipStatuses.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsMemberShipStatuses);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddMemberShipStatus([FromBody]MemberShipStatus _MemberShipStatus)
        {
            MemberShipStatusRepository MemberShipStatuses = new MemberShipStatusRepository();
            MemberShipStatuses.InsertMemberShipStatus(_MemberShipStatus);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_MemberShipStatus.MembershipstatusID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateMemberShipStatus([FromBody]MemberShipStatus _MemberShipStatus)
        {
            MemberShipStatusRepository MemberShipStatuses = new MemberShipStatusRepository();
            MemberShipStatuses.UpdateMemberShipStatus(_MemberShipStatus);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_MemberShipStatus.MembershipstatusID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteMemberShipStatus(int id)
        {
            MemberShipStatusRepository MemberShipStatuses = new MemberShipStatusRepository();
            MemberShipStatuses.DeleteMemberShipStatus(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}