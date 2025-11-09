using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("LoaiSanPham")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; } // LoaiID

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } // TenLoai

        public virtual ICollection<Product> Products { get; set; }
    }
}