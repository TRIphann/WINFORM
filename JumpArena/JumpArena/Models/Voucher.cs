namespace JumpArena.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voucher")]
    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int VoucherID { get; set; }

        [Required]
        [StringLength(50)]
        public string VoucherCode { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(20)]
        public string DiscountType { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal MinimumOrderValue { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
