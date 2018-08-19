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
    public class LibraryUserController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetMemberShipTypesByID(int id)
        {
            LibraryUserRepository ctxLibraryUsers = new LibraryUserRepository();

            LibraryUser _LibraryUser = ctxLibraryUsers.GetLibraryUsers().FirstOrDefault(x => x.LibraryUserID == id);

            if (_LibraryUser != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _LibraryUser);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllMemberShipTypes()
        {
            LibraryUserRepository LibraryUsers = new LibraryUserRepository();
            IEnumerable<LibraryUser> lsLibraryUsers;

            lsLibraryUsers = LibraryUsers.GetLibraryUsers();
            if (lsLibraryUsers.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsLibraryUsers);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddMemberShipType([FromBody]LibraryUser _LibraryUser)
        {
            LibraryUserRepository LibraryUsers = new LibraryUserRepository();
            LibraryUsers.InsertLibraryUser(_LibraryUser);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LibraryUser.LibraryUserID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateMemberShipType([FromBody]LibraryUser _LibraryUser)
        {
            LibraryUserRepository LibraryUsers = new LibraryUserRepository();
            LibraryUsers.UpdateLibraryUser(_LibraryUser);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LibraryUser.LibraryUserID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteMemberShipType(int id)
        {
            LibraryUserRepository LibraryUsers = new LibraryUserRepository();
            LibraryUsers.DeleteLibraryUser(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}