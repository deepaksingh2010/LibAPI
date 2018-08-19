using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class LateFeeDetailsRepository
    {
        private LibraryDBContext context = null;
        public LateFeeDetailsRepository()
        {
            context = new LibraryDBContext();

        }
        public List<LateFeeDetails> GetLateFeeDetails()
        {
            return context.DetailsLateFees.ToList();
        }
        public int InsertLateFeeDetails(LateFeeDetails _LateFeeDetails)
        {
            context.DetailsLateFees.Add(_LateFeeDetails);
            return context.SaveChanges();

        }
        public int UpdateLateFeeDetails(LateFeeDetails _LateFeeDetails)
        {
            LateFeeDetails LateFeeDetailsToUpdate = context.DetailsLateFees.SingleOrDefault(x => x.LateFeeDetailID == _LateFeeDetails.LateFeeDetailID);
            LateFeeDetailsToUpdate.LateFeeValue = _LateFeeDetails.LateFeeValue;
            LateFeeDetailsToUpdate.Description = _LateFeeDetails.Description;
            LateFeeDetailsToUpdate.DurationInDays = _LateFeeDetails.DurationInDays;
            
            return context.SaveChanges();
        }
        public int DeleteLateFeeDetails(int _LateFeeDetails)
        {
            LateFeeDetails LateFeeDetailsToDelete = context
                .DetailsLateFees.SingleOrDefault(x => x.LateFeeDetailID ==_LateFeeDetails);
            context.DetailsLateFees.Remove(LateFeeDetailsToDelete);
            return context.SaveChanges();

        }
    }
}