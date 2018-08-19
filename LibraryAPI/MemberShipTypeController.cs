using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using LibAPI.DataAccess;
using LibAPI;
using System.Net;
namespace LibraryAPI
{
    public class MemberShipTypeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetMemberShipTypesByID(int id)
        {
            MemberShipTypeRepository ctxMemberShipTypes = new MemberShipTypeRepository();

            MemberShipType _MemberShipType = ctxMemberShipTypes.GetMemberShipType().FirstOrDefault(x => x.MembershipTypeID == id);

            if (_MemberShipType!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _MemberShipType);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllMemberShipTypes()
        {
            MemberShipTypeRepository MemberShipTypes = new MemberShipTypeRepository();
            IEnumerable<MemberShipType> lsMemberShipType;

            lsMemberShipType = MemberShipTypes.GetMemberShipType();
            if (lsMemberShipType.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsMemberShipType);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddMemberShipType([FromBody]MemberShipType _MemberShipType)
        {
            MemberShipTypeRepository MemberShipTypes = new MemberShipTypeRepository();
            MemberShipTypes.InsertMemberShipType(_MemberShipType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/"+(_MemberShipType.MembershipTypeID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateMemberShipType([FromBody]MemberShipType _MemberShipType)
        {
            MemberShipTypeRepository MemberShipTypes = new MemberShipTypeRepository();
            MemberShipTypes.UpdateMemberShipType(_MemberShipType);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_MemberShipType.MembershipTypeID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteMemberShipType(int id)
        {
            MemberShipTypeRepository MemberShipTypes = new MemberShipTypeRepository();
            MemberShipTypes.DeleteMemberShipType(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}