namespace JumpArena.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentTransaction")]
    public partial class PaymentTransaction
    {
        public int PaymentTransactionID { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        [StringLength(100)]
        public string TransactionCode { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public int InvoiceID { get; set; }

        public int PaymentMethodID { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
