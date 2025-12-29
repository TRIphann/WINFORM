using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("Voucher")]
    public class Voucher
    {
        [Key]
        public int VoucherID { get; set; }

        [Required]
        [StringLength(50)]
        public string? VoucherCode { get; set; } // MaVoucher

        [StringLength(255)]
        public string? Description { get; set; } // MoTa

        [StringLength(20)]
        public string? DiscountType { get; set; } // LoaiGiamGia

        [Column(TypeName = "decimal(18, 0)")]
        public decimal DiscountValue { get; set; } // GiaTriGiam

        [Column(TypeName = "decimal(18, 0)")]
        public decimal MinimumOrderValue { get; set; } // DonHangToiThieu

        public DateTime? StartDate { get; set; } // NgayBatDau
        public DateTime? EndDate { get; set; } // NgayKetThuc
    }
}