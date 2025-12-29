using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("LichSuHoatDong")]
    public class AuditLog
    {
        [Key]
        public int LogID { get; set; }

        public int? InvoiceID { get; set; } // HoaDonID
        public int? UserID { get; set; } // NguoiDungID

        [StringLength(50)]
        public string ActionType { get; set; } // HanhDong

        public DateTime Timestamp { get; set; } // ThoiGian
        public string Changes { get; set; } // NoiDungThayDoi
    }
}