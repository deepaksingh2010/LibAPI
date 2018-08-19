using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public enum IssueMethods
    {
        basic,
        advanced
    }
    public abstract class BaseBookIssuedRepository
    {
        public LibraryDBContext context = null;
        public BaseBookIssuedRepository()
        {
            context = new LibraryDBContext();
        }
    }
    public class BookIssuedRepository : BaseBookIssuedRepository
    {
        public List<BookIssued> GetBookIssued()
        {
            return context.BooksIssued.Include("Book").Include("LibraryUser").Include("BookIssueStatus").ToList();
        }
        public int InsertBookIssued(BookIssued _BooksIssued)
        {
            context.BooksIssued.Add(_BooksIssued);
            return context.SaveChanges();

        }
        public int UpdateBookIssued(BookIssued _BooksIssued)
        {
            BookIssued BookIssuedToUpdate = context.BooksIssued.SingleOrDefault(x => x.BookIssuedID == _BooksIssued.BookIssuedID);
            BookIssuedToUpdate.BookIssuedStatusID = _BooksIssued.BookIssuedStatusID;
            BookIssuedToUpdate.Coments = _BooksIssued.Coments;
            BookIssuedToUpdate.IssueDate = _BooksIssued.IssueDate;
            BookIssuedToUpdate.LateFee = _BooksIssued.LateFee;
            BookIssuedToUpdate.OwnerID = _BooksIssued.OwnerID;
            BookIssuedToUpdate.RetrunDate = _BooksIssued.RetrunDate;
            return context.SaveChanges();
        }
        public int DeleteBookIssued(int _BooksIssued)
        {
            BookIssued BookIssuedToDelete = context
                .BooksIssued.SingleOrDefault(x => x.BookIssuedID == _BooksIssued);
            context.BooksIssued.Remove(BookIssuedToDelete);
            return context.SaveChanges();

        }
    }
    public interface IIssueBooks
    {
        int IssueBook(BookIssued _BooksIssued);
    }
    public class BasicIssueSystem : IIssueBooks
    {

        public int IssueBook(BookIssued _BooksIssued)
        {
            throw new NotImplementedException();
        }
    }

}

#region

//using LibAPI.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace LibAPI.DataAccess
//{
//    public class BookIssuedRepository
//    {
//        private LibraryDBContext context = null;
//        public BookIssuedRepository()
//        {
//            context = new LibraryDBContext();

//        }
//        public List<BookIssued> GetBookIssued()
//        {
//            return context.BooksIssued.Include("Book").Include("LibraryUser").Include("BookIssueStatus").ToList();
//        }
//        public int InsertBookIssued(BookIssued _MemberShipType)
//        {
//            context.BooksIssued.Add(_MemberShipType);
//            return context.SaveChanges();

//        }
//        public int UpdateBookIssued(BookIssued _BooksIssued)
//        {
//            BookIssued BookIssuedToUpdate = context.BooksIssued.SingleOrDefault(x => x.BookIssuedID == _BooksIssued.BookIssuedID);
//            BookIssuedToUpdate.BookIssuedStatusID = _BooksIssued.BookIssuedStatusID;
//            BookIssuedToUpdate.Coments = _BooksIssued.Coments;
//            BookIssuedToUpdate.IssueDate = _BooksIssued.IssueDate;
//            BookIssuedToUpdate.LateFee  = _BooksIssued.LateFee;
//            BookIssuedToUpdate.OwnerID = _BooksIssued.OwnerID;
//            BookIssuedToUpdate.RetrunDate = _BooksIssued.RetrunDate;            
//            return context.SaveChanges();
//        }
//        public int DeleteBookIssued(int _BooksIssued)
//        {
//            BookIssued BookIssuedToDelete = context
//                .BooksIssued.SingleOrDefault(x => x.BookIssuedID == _BooksIssued);
//            context.BooksIssued.Remove(BookIssuedToDelete);
//            return context.SaveChanges();

//        }
//    }
//}
#endregion