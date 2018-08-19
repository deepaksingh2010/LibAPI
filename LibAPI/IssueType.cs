using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class IssueType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IssueTypeID { get; set; }
        [Required]
        public string IssueTypeName { get; set; }
        public double MaxPrice { get; set; }
        public double FeePerDay { get; set; }
        public List<Book> Books { get; set; }
    }
}