using System;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public partial class PaymentReceiptModel : BaseOrgModel
    {
        public string Reference { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal AmountPaid { get; set; }
        public long CustomerId { get; set; }
        public PaymentType PaymentType { get; set; }
        //public CustomerModel Customer { get; set; }
        //public long? ChequeId { get; set; }
        //public ChequeModel? Cheque { get; set; }
        //public PayMode? ModeOfPayment { get; set; }
        //public virtual ICollection<InvoiceModel>? InvoicesSettled { get; set; }
    }
}
