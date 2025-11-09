using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("MaCheckin")]
    public class CheckinCode
    {
        [Key]
        public int CheckinID { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; } // MaCode

        public DateTime? CheckinTime { get; set; } // ThoiGianCheckin
        public DateTime? CheckoutTime { get; set; } // ThoiGianCheckout
        public DateTime ExpiryDate { get; set; } // ThoiHanSuDung

        [StringLength(50)]
        public string Status { get; set; } // TrangThai

        public int? InvoiceDetailID { get; set; }
        [ForeignKey("InvoiceDetailID")]
        public virtual InvoiceDetail InvoiceDetail { get; set; }

        public int? CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}