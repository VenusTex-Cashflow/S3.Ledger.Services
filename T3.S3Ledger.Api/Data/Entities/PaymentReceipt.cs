using System;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public partial class PaymentReceipt : BaseOrgEntity
    {
        public string Reference { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal AmountPaid { get; set; }
        public long CustomerId { get; set; }
        public PaymentType PaymentType { get; set; }
        //[ForeignKey("CustomerId")]
        //public Customer Customer { get; set; }
        //public long? ChequeId { get; set; }
        //[ForeignKey("ChequeId")]
        //public Cheque? Cheque { get; set; }
        //public PayMode? ModeOfPayment { get; set; }
        //public virtual ICollection<Invoice>? InvoicesSettled { get; set; }
    }
}
