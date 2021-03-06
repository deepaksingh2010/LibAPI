﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class BooksCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BooksCategoryID { get; set; }
        [Required]
        public string Category { get; set; }
        public List<Book> Books { get; set; }
    }
}