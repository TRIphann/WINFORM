using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("ChiTietHoaDon")]
    public class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailID { get; set; } // ChiTietID

        public int Quantity { get; set; } // SoLuong

        [Column(TypeName = "decimal(18, 0)")]
        public decimal PriceAtPurchase { get; set; } // DonGiaTaiThoiDiemMua

        public int InvoiceID { get; set; }
        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public virtual CheckinCode CheckinCode { get; set; }
    }
}