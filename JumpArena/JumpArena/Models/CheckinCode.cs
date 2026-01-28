namespace JumpArena.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckinCode")]
    public partial class CheckinCode
    {
        [Key]
        public int CheckinID { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        public DateTime? CheckinTime { get; set; }

        public DateTime? CheckoutTime { get; set; }

        public DateTime ExpiryDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? InvoiceDetailID { get; set; }

        public int? CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual InvoiceDetail InvoiceDetail { get; set; }
    }
}
