using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("HoaDon")]
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; } // HoaDonID

        public DateTime CreatedDate { get; set; } // NgayTao

        [Column(TypeName = "decimal(18, 0)")]
        public decimal TotalOriginalAmount { get; set; } // TongTienGoc

        [Column(TypeName = "decimal(18, 0)")]
        public decimal DiscountAmount { get; set; } // SoTienGiam

        [NotMapped] // Báo EF Core không tạo cột này
        public decimal FinalAmount => TotalOriginalAmount - DiscountAmount;

        [StringLength(50)]
        public string Status { get; set; } // TrangThai

        [StringLength(50)]
        public string PaymentStatus { get; set; } // TrangThaiThanhToan

        public int? CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public int? VoucherID { get; set; }
        [ForeignKey("VoucherID")]
        public virtual Voucher Voucher { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; }
    }
}