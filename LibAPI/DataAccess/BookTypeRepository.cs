using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class BookTypeRepository
    {
         private LibraryDBContext context = null;
         public BookTypeRepository()
        {
            context = new LibraryDBContext();

        }
         public List<BookType> GetBookType()
        {
            return context.BookTypes.Include("Books").ToList();
        }
         public int InsertBookType(BookType _BookType)
        {
            context.BookTypes.Add(_BookType);
            return context.SaveChanges();

        }
         public int UpdateBookType(BookType __BookType)
        {
            BookType BookTypeToUpdate = context.BookTypes.SingleOrDefault(x => x.BookTypeID == __BookType.BookTypeID);
            BookTypeToUpdate.BookTypeName = __BookType.BookTypeName;
            
            return context.SaveChanges();
        }
         public int DeleteBookType(int _BookTypeID)
        {
            BookType BookTypeToDelete = context
                .BookTypes.SingleOrDefault(x => x.BookTypeID == _BookTypeID);
            context.BookTypes.Remove(BookTypeToDelete);
            return context.SaveChanges();

        }
    }
}