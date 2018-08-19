using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LibAPI
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        [Index("IX_RegistrationNumber", IsUnique = true)]
        public int RegistrationNumber { get; set; }

        [Required]
        [Index("IX_bookCategoryID")]
        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public BooksCategory BooksCategory { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Index("IX_bookBookTypeID")]
        public int? BookTypeID { get; set; }
        [ForeignKey("BookTypeID")]
        public BookType BookType { get; set; }

        public double Price { get; set; }
        public string SourceOfBook { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Index("LateFeeDetailID")]
        public int? LateFeeDetailID { get; set; }
        [ForeignKey("LateFeeDetailID")]
        public LateFeeDetails LateFeeDetails { get; set; }
    }
}