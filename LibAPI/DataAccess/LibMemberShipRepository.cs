using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class LibMemberShipRepository
    {
        private LibraryDBContext context = null;
        public LibMemberShipRepository()
        {
            context = new LibraryDBContext();

        }
        public List<LibMemeberShip> GetLibMemberShip()
        {
            return context.LibMemberShips.Include("LibraryUser").Include("MemberShipStatus").Include("MemberShipType").ToList();
        }
        public int InsertLibMemberShip(LibMemeberShip _LibMemeberShip)
        {
            context.LibMemberShips.Add(_LibMemeberShip);
            return context.SaveChanges();

        }
        public int UpdateLibMemberShip(LibMemeberShip _LibMemeberShip)
        {
            LibMemeberShip LibMemeberShipToUpdate = context.LibMemberShips.SingleOrDefault(x => x.LibMemberShipID == _LibMemeberShip.LibMemberShipID);
            LibMemeberShipToUpdate.LibraryMemberShipTypeID = _LibMemeberShip.LibraryMemberShipTypeID;
            LibMemeberShipToUpdate.MemberShipStatusID = _LibMemeberShip.MemberShipStatusID;
            LibMemeberShipToUpdate.PaidOn = _LibMemeberShip.PaidOn;
            LibMemeberShipToUpdate.PaidTill = _LibMemeberShip.PaidTill;
            LibMemeberShipToUpdate.UserID = _LibMemeberShip.UserID;
            LibMemeberShipToUpdate.FeeCollected = _LibMemeberShip.FeeCollected;
            LibMemeberShipToUpdate.CreatedOn = _LibMemeberShip.CreatedOn;
            return context.SaveChanges();
        }
        public int DeleteLibMemeberShip(int _MembershipTypeID)
        {
            LibMemeberShip LibMemeberShipToDelete = context
                .LibMemberShips.SingleOrDefault(x => x.LibMemberShipID ==_MembershipTypeID);
            context.LibMemberShips.Remove(LibMemeberShipToDelete);
            return context.SaveChanges();

        }
    }
}