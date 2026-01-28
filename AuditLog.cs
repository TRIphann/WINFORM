namespace JumpArena.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditLog")]
    public partial class AuditLog
    {
        [Key]
        public int LogID { get; set; }

        public int? InvoiceID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string ActionType { get; set; }

        public DateTime Timestamp { get; set; }

        public string Changes { get; set; }
    }
}
