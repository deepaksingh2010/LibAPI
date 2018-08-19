using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class BookType
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookTypeID { get; set; }
       [Required]
        public string BookTypeName { get; set; }
       public List<Book> Books { get; set; }
    }
}