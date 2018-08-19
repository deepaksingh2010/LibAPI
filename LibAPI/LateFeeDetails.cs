using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class LateFeeDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LateFeeDetailID { get; set; }
        public string Description { get; set; }
        public int DurationInDays { get; set; }
        public double LateFeeValue { get; set; }
    }
}