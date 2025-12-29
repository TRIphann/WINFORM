using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("KhachHang")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; } // KhachHangID

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } // SoDienThoai

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } // Ho

        [StringLength(50)]
        public string MiddleName { get; set; } // TenDem

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } // Ten

        public DateTime? BirthDate { get; set; } // NgaySinh

        [StringLength(255)]
        public string Address { get; set; } // DiaChi

        [StringLength(255)]
        public string CompanyName { get; set; } // TenCongTy

        [StringLength(255)]
        public string CompanyAddress { get; set; } // DiaChiCongTy

        [StringLength(20)]
        public string TaxCode { get; set; } // MaSoThue

        [StringLength(100)]
        public string LegalRepresentative { get; set; } // NguoiDaiDienPhapLuat
    }
}