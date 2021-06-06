using System;

namespace T3.S3Ledger.Api.Models
{
    public partial class InvoiceModel : BaseOrgModel
    {
        public string ReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public long CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        //public long SalesmanId { get; set; }
        //public SalesmanModel Salesman { get; set; } = null;
        //public InvoiceStatus InvoiceStatus { get; set; } = InvoiceStatus.None;
        //public PayMode PaymentMethod { get; set; } = PayMode.Credit;
        //public bool? GoodsDelivered { get; set; }
        //public virtual ICollection<PaymentReceiptModel>? Payments { get; set; }
        //public decimal? DiscountAmount { get; set; }
        //public decimal? TaxAmount { get; set; }
    }
}
