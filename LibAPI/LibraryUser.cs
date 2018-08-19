using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LibAPI
{
    public class LibraryUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryUserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string PhoneNumber { get; set; }
        
        [Index("IX_Referencedby")]
        public int? ReferencedID { get; set; }
        [ForeignKey("ReferencedID")]
        public LibraryUser ReferenceBY { set; get; }
    }
}