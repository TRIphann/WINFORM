using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("SanPham")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; } // SanPhamID

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; } // TenSanPham

        [StringLength(500)]
        public string? Description { get; set; } // MoTa

        [Required]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; } // DonGia

        public int StockQuantity { get; set; } // SoLuongTonKho

        public int? CategoryID { get; set; } // LoaiID
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}