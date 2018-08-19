using LibAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAPI.DataAccess
{
    public class BookCategoryRepository
    {
        private LibraryDBContext context = null;
        public BookCategoryRepository()
        {
            context = new LibraryDBContext();

        }
        public List<BooksCategory> GetBooksCategory()
        {
            return context.BooksCategories.Include("Books").ToList();
        }
        public int InsertBooksCategory(BooksCategory _BooksCategory)
        {
            context.BooksCategories.Add(_BooksCategory);
            return context.SaveChanges();

        }
        public int UpdateBooksCategory(BooksCategory __BooksCategory)
        {
            BooksCategory BooksCategoryToUpdate = context.BooksCategories.SingleOrDefault(x => x.BooksCategoryID == __BooksCategory.BooksCategoryID);
            BooksCategoryToUpdate.Category = __BooksCategory.Category;
            
            return context.SaveChanges();
        }
        public int DeleteBookCategory(int _BookCategoryID)
        {
            BooksCategory BooksCategoryToDelete = context
                .BooksCategories.SingleOrDefault(x => x.BooksCategoryID == _BookCategoryID);
            context.BooksCategories.Remove(BooksCategoryToDelete);
            return context.SaveChanges();

        }
    }
}