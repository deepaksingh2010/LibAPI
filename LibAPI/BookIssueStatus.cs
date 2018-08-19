using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class BookIssueStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookIssueStatusID { get; set; }
        [Required]
        public string BookIssueStatusName { get; set; }
        public List<Book> Books { get; set; }
    }
}