namespace JumpArena.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            PaymentTransactions = new HashSet<PaymentTransaction>();
        }

        public int InvoiceID { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal TotalOriginalAmount { get; set; }

        public decimal DiscountAmount { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public int? CustomerID { get; set; }

        public int? UserID { get; set; }

        public int? VoucherID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual User User { get; set; }

        public virtual Voucher Voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; }
    }
}
