using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class BooksRepository
    {
        private LibraryDBContext context = null;
        public BooksRepository()
        {
            context = new LibraryDBContext();

        }
        public List<Book> GetBooks()
        {
            return context.Books.Include("BooksCategory").Include("BookType").Include("LateFeeDetails").ToList();
        }
        public int InsertBook(Book _Book)
        {
            context.Books.Add(_Book);
            return context.SaveChanges();

        }
        public int UpdateBook(Book _Book)
        {
            Book BookToUpdate = context.Books.SingleOrDefault(x => x.BookID == _Book.BookID);
            BookToUpdate.Author = _Book.Author;
            BookToUpdate.BookName = _Book.BookName;
            BookToUpdate.BookTypeID = _Book.BookTypeID;
            BookToUpdate.CategoryID = _Book.CategoryID;
            BookToUpdate.Description = _Book.Description;
            BookToUpdate.LateFeeDetailID = _Book.LateFeeDetailID;
            BookToUpdate.Price = _Book.Price;
            BookToUpdate.RegistrationNumber = _Book.RegistrationNumber;
            BookToUpdate.SourceOfBook = _Book.SourceOfBook;            
            return context.SaveChanges();
        }
        public int DeleteBook(int _BookID)
        {
            Book BookToDelete = context.Books.SingleOrDefault(x => x.BookID == _BookID);
            context.Books.Remove(BookToDelete);
            return context.SaveChanges();

        }
    }
}