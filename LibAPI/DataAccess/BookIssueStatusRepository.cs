using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class BookIssueStatusRepository
    {
        private LibraryDBContext context = null;
        public BookIssueStatusRepository()
        {
            context = new LibraryDBContext();

        }
        public List<BookIssueStatus> GetBookIssueStatus()
        {
            return context.BookIssueStatuses.Include("Books").ToList();
        }
        public int InsertBookIssueStatus(BookIssueStatus _BookIssueStatus)
        {
            context.BookIssueStatuses.Add(_BookIssueStatus);
            return context.SaveChanges();

        }
        public int UpdateBookIssueStatus(BookIssueStatus __BookIssueStatus)
        {
            BookIssueStatus BookIssueStatusToUpdate = context.BookIssueStatuses.SingleOrDefault(x => x.BookIssueStatusID == __BookIssueStatus.BookIssueStatusID);
            BookIssueStatusToUpdate.BookIssueStatusName = __BookIssueStatus.BookIssueStatusName;
            
            return context.SaveChanges();
        }
        public int DeleteBookIssueStatus(int _BookIssueStatusID)
        {
            BookIssueStatus BookIssueStatusToDelete = context
                .BookIssueStatuses.SingleOrDefault(x => x.BookIssueStatusID == _BookIssueStatusID);
            context.BookIssueStatuses.Remove(BookIssueStatusToDelete);
            return context.SaveChanges();

        }
    }
}