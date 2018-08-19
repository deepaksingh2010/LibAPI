using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibAPI
{
    public class BookIssued
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookIssuedID { get; set; }

        [Required]
        [Index("IX_bookissueedID")]
        public int? BookID { get; set; }
        [ForeignKey("BookID")]
        public Book Book { get; set; }


        [Required]
        [Index("IX_LibraryUser")]
        public int? OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public LibraryUser LibraryUser { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime RetrunDate { get; set; }

        [Required]
        [Index("IX_BookIssuedStatusID")]
        public int? BookIssuedStatusID { get; set; }
        [ForeignKey("BookIssuedStatusID")]
        public BookIssueStatus BookIssueStatus { get; set; }

        public double LateFee { get; set; }
        [MaxLength(150)]
        public string Coments { get; set; }
    }
}