using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class MemberShipType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembershipTypeID { get; set; }
        [Required]
        public string MembershipTypeName { get; set; }
        public int MaxIssueDays { get; set; }
    }
}