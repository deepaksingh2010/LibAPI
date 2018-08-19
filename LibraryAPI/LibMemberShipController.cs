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
    public class LibMemberShipController:ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetLibLibMemeberShipID(int id)
        {
            LibMemberShipRepository ctxLibMemberShips = new LibMemberShipRepository();

            LibMemeberShip _LibMemeberShip = ctxLibMemberShips.GetLibMemberShip().FirstOrDefault(x => x.LibMemberShipID == id);

            if (_LibMemeberShip != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _LibMemeberShip);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllLibLibMemeberShip()
        {
            LibMemberShipRepository LibMemberShips = new LibMemberShipRepository();
            IEnumerable<LibMemeberShip> lsLibMemeberShips;

            lsLibMemeberShips = LibMemberShips.GetLibMemberShip();
            if (lsLibMemeberShips.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lsLibMemeberShips);
            }
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }
        [HttpPost]
        public HttpResponseMessage AddLibLibMemeberShip([FromBody]LibMemeberShip _LibMemberShip)
        {
            LibMemberShipRepository LibMemberShips = new LibMemberShipRepository();
            LibMemberShips.InsertLibMemberShip(_LibMemberShip);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Created);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LibMemberShip.LibMemberShipID).ToString());
            return ms;
        }
        [HttpPut]
        public HttpResponseMessage UpdateLibMemeberShip([FromBody]LibMemeberShip _LibMemberShip)
        {
            LibMemberShipRepository LibMemberShips = new LibMemberShipRepository();
            LibMemberShips.UpdateLibMemberShip(_LibMemberShip);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.OK);
            ms.Headers.Location = new Uri(Request.RequestUri + "/" + (_LibMemberShip.LibMemberShipID).ToString());
            return ms;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteLibMemeberShip(int id)
        {
            LibMemberShipRepository LibMemberShips = new LibMemberShipRepository();
            LibMemberShips.DeleteLibMemeberShip(id);
            HttpResponseMessage ms = Request.CreateResponse(HttpStatusCode.Accepted);
            return ms;
        }
    }
}