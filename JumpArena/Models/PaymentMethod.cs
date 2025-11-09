using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("PhuongThucThanhToan")]
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodID { get; set; } // PhuongThucID

        [Required]
        [StringLength(100)]
        public string MethodName { get; set; } // TenPhuongThuc

        public bool IsDigital { get; set; }
    }
}