using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class MemberShipTypeRepository
    {
        private LibraryDBContext context = null;
        public MemberShipTypeRepository()
        {
            context = new LibraryDBContext();

        }
        public List<MemberShipType> GetMemberShipType()
        {
            return context.MemberShipTypes.ToList();
        }
        public int InsertMemberShipType(MemberShipType _MemberShipType)
        {
            context.MemberShipTypes.Add(_MemberShipType);
            return context.SaveChanges();

        }
        public int UpdateMemberShipType(MemberShipType _MemberShipType)
        {
            MemberShipType MemberShipTypeToUpdate = context.MemberShipTypes.SingleOrDefault(x => x.MembershipTypeID == _MemberShipType.MembershipTypeID);
            MemberShipTypeToUpdate.MembershipTypeName = _MemberShipType.MembershipTypeName;
            return context.SaveChanges();
        }
        public int DeleteMemberShipType(int _MembershipTypeID)
        {
            MemberShipType MemberShipTypeToDelete = context
                .MemberShipTypes.SingleOrDefault(x => x.MembershipTypeID ==_MembershipTypeID);
            context.MemberShipTypes.Remove(MemberShipTypeToDelete);
            return context.SaveChanges();

        }
    }
}