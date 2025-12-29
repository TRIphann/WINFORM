using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("NguoiDung")]
    public class User
    {
        [Key]
        public int UserID { get; set; } // NguoiDungID

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } // HoTen

        public DateTime? BirthDate { get; set; } // NgaySinh

        [StringLength(255)]
        public string Address { get; set; } // DiaChi

        [Required]
        [StringLength(50)]
        public string Username { get; set; } // TenDangNhap

        [Required]
        [StringLength(255)]
        public string Password { get; set; } // MatKhau

        public int? RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
    }
}