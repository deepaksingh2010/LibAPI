using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class MemberShipStatusRepository
    {
        private LibraryDBContext context = null;
        public MemberShipStatusRepository()
        {
            context = new LibraryDBContext();

        }
        public List<MemberShipStatus> GetMemberShipStatus()
        {
            return context.MemberShipStatuses.ToList();
        }
        public int InsertMemberShipStatus(MemberShipStatus _MemberShipStatus)
        {
            context.MemberShipStatuses.Add(_MemberShipStatus);
            return context.SaveChanges();

        }
        public int UpdateMemberShipStatus(MemberShipStatus _MemberShipStatus)
        {
            MemberShipStatus MemberShipStatusToUpdate = context.MemberShipStatuses.SingleOrDefault(x => x.MembershipstatusID == _MemberShipStatus.MembershipstatusID);
            MemberShipStatusToUpdate.StatusName = _MemberShipStatus.StatusName;
            return context.SaveChanges();
        }
        public int DeleteMemberShipStatus(int _MembershipstatusID)
        {
            MemberShipStatus _MemberShipStatusIDToDelete = context.MemberShipStatuses.SingleOrDefault(x => x.MembershipstatusID == _MembershipstatusID);
            context.MemberShipStatuses.Remove(_MemberShipStatusIDToDelete);
            return context.SaveChanges();

        }
    }
}