using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class LibraryUserRepository
    {
        private LibraryDBContext context = null;
        public LibraryUserRepository()
        {
            context = new LibraryDBContext();

        }
        public List<LibraryUser> GetLibraryUsers()
        {
            return context.LibraryUsers.ToList();
        }
        public int InsertLibraryUser(LibraryUser _LibraryUser)
        {
            context.LibraryUsers.Add(_LibraryUser);
            return context.SaveChanges();

        }
        public int UpdateLibraryUser(LibraryUser _LibraryUser)
        {
            LibraryUser LibraryUserToUpdate = context.LibraryUsers.SingleOrDefault(x => x.LibraryUserID ==_LibraryUser.LibraryUserID);
            LibraryUserToUpdate.Name = _LibraryUser.Name;
            LibraryUserToUpdate.PhoneNumber = _LibraryUser.PhoneNumber;
            LibraryUserToUpdate.ReferencedID = _LibraryUser.ReferencedID;
            LibraryUserToUpdate.Address = _LibraryUser.Address;
            LibraryUserToUpdate.EmailID = _LibraryUser.EmailID;
            return context.SaveChanges();
        }
        public int DeleteLibraryUser(int _LibraryUserID)
        {
            LibraryUser LibraryUserDelete = context
                .LibraryUsers.SingleOrDefault(x => x.LibraryUserID == _LibraryUserID);
            context.LibraryUsers.Remove(LibraryUserDelete);
            return context.SaveChanges();

        }
    }
}