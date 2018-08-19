using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibAPI
{
    public class LibMemeberShip
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibMemberShipID { get; set; }

        [Required]
        [Index("IX_LibMemeberShipUser")]
        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public LibraryUser LibraryUser { get; set; }

        [Required]
        [Index("IX_MemberShipStatusID")]
        public int? MemberShipStatusID { get; set; }
        [ForeignKey("MemberShipStatusID")]
        public MemberShipStatus MemberShipStatus { get; set; }

        [Required]
        [Index("IX_LibraryMemberShipTypeID")]
        public int? LibraryMemberShipTypeID { get; set; }
        [ForeignKey("LibraryMemberShipTypeID")]
        public MemberShipType MemberShipType { get; set; }

        public double FeeCollected { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime PaidOn { get; set; }
        public DateTime PaidTill { get; set; }

        
        
    }
}