using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("ThanhToan")]
    public class PaymentTransaction
    {
        [Key]
        public int PaymentTransactionID { get; set; } // ThanhToanID

        [Column(TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; } // SoTien

        public DateTime PaymentDate { get; set; } // NgayThanhToan

        [StringLength(100)]
        public string TransactionCode { get; set; } // MaGiaoDich

        [StringLength(255)]
        public string Note { get; set; } // GhiChu

        public int InvoiceID { get; set; }
        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }

        public int PaymentMethodID { get; set; }
        [ForeignKey("PaymentMethodID")]
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}