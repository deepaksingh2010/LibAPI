using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class IssueTypeRepository
    {
        private LibraryDBContext context = null;
        public IssueTypeRepository()
        {
            context = new LibraryDBContext();

        }
        public List<IssueType> GetIssueType()
        {
            return context.IssueTypes.Include("Books").ToList();
        }
        public int InsertIssueType(IssueType _IssueType)
        {
            context.IssueTypes.Add(_IssueType);
            return context.SaveChanges();

        }
        public int UpdateIssueType(IssueType _IssueType)
        {
            IssueType LateFeeDetailsToUpdate = context.IssueTypes.SingleOrDefault(x => x.IssueTypeID == _IssueType.IssueTypeID);
            LateFeeDetailsToUpdate.IssueTypeName = _IssueType.IssueTypeName;
            LateFeeDetailsToUpdate.MaxPrice = _IssueType.MaxPrice;
            
            return context.SaveChanges();
        }
        public int DeleteIssueType(int _IssueTypeID)
        {
            IssueType IssueTypeToDelete = context
                .IssueTypes.SingleOrDefault(x => x.IssueTypeID == _IssueTypeID);
            context.IssueTypes.Remove(IssueTypeToDelete);
            return context.SaveChanges();

        }
    }
}