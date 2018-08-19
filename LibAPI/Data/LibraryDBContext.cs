using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibAPI.Data
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
            : base("name=LibraryDBContext")
        {
          
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookIssued> BooksIssued { get; set; }
        public DbSet<BookIssueStatus> BookIssueStatuses { get; set; }
        public DbSet<BooksCategory> BooksCategories { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<LateFeeDetails> DetailsLateFees { get; set; }
        public DbSet<LibMemeberShip> LibMemberShips { get; set; }
        public DbSet<LibraryUser> LibraryUsers { get; set; }
        public DbSet<MemberShipStatus> MemberShipStatuses { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region BOOK
            SPBOOK(modelBuilder);
            #endregion

            #region BookIssued
            SPBookIssued(modelBuilder);
            #endregion
            #region BookIssueStatus
            SPBookIssueStatus(modelBuilder);
            #endregion
            #region BooksCategory
            SPBooksCategory(modelBuilder);
            #endregion
            #region BookType
            SPBookType(modelBuilder);
            #endregion
            #region IssueType
            SPIssueType(modelBuilder);
            #endregion
            #region LateFeeDetails
            SPLateFeeDetails(modelBuilder);
            #endregion
            #region LibMemeberShip
            SPLibMemberShip(modelBuilder);
            #endregion
            #region LibraryUser
            SPLibraryUser(modelBuilder);
            #endregion
            #region MemberShipStatus
            SPMemberShipStatus(modelBuilder);
            #endregion
            #region MemberShipType
            SPMemberShipType(modelBuilder);
            #endregion
            base.OnModelCreating(modelBuilder);
        }

        public virtual void SPMemberShipType(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberShipType>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertMemberShipType")));
            modelBuilder.Entity<MemberShipType>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateMemberShipType")));
            modelBuilder.Entity<MemberShipType>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteMemberShipType")));
        }

        public virtual void SPMemberShipStatus(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberShipStatus>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertMemberShipStatus")));
            modelBuilder.Entity<MemberShipStatus>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateMemberShipStatus")));
            modelBuilder.Entity<MemberShipStatus>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteMemberShipStatus")));
        }

        public virtual void SPLibraryUser(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibraryUser>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertLibraryUser")));
            modelBuilder.Entity<LibraryUser>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateLibraryUser")));
            modelBuilder.Entity<LibraryUser>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteLibraryUser")));
        }

        public virtual void SPLibMemberShip(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibMemeberShip>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertLibMemeberShip")));
            modelBuilder.Entity<LibMemeberShip>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateLibMemeberShip")));
            modelBuilder.Entity<LibMemeberShip>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteLibMemeberShip")));
        }

        public virtual void SPLateFeeDetails(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LateFeeDetails>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertLateFeeDetails")));
            modelBuilder.Entity<LateFeeDetails>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateLateFeeDetails")));
            modelBuilder.Entity<LateFeeDetails>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteLateFeeDetails")));
        }

        public virtual void SPIssueType(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IssueType>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertIssueType")));
            modelBuilder.Entity<IssueType>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateIssueType")));
            modelBuilder.Entity<IssueType>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteIssueType")));
        }

        public virtual void SPBookType(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookType>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertBookType")));
            modelBuilder.Entity<BookType>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateBookType")));
            modelBuilder.Entity<BookType>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteBookType")));
        }

        public virtual void SPBooksCategory(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksCategory>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertBooksCategory")));
            modelBuilder.Entity<BooksCategory>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateBooksCategory")));
            modelBuilder.Entity<BooksCategory>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteBooksCategory")));
        }

        public virtual void SPBookIssueStatus(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookIssueStatus>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertBookIssueStatus")));
            modelBuilder.Entity<BookIssueStatus>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateBookIssueStatus")));
            modelBuilder.Entity<BookIssueStatus>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteBookIssueStatus")));
        }

        public virtual void SPBookIssued(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookIssued>()
           .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertBookIssued")));
            modelBuilder.Entity<BookIssued>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateBookIssued")));
            modelBuilder.Entity<BookIssued>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteBookIssued")));
        }

        public virtual void SPBOOK(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertBook")));
            modelBuilder.Entity<Book>()
                .MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateBook")));
            modelBuilder.Entity<Book>()
                .MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteBook")));
        }
    }
}