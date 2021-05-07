using System;
using System.Collections.Generic;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public partial class InvoiceModel : BaseOrgModel
    {
        public string ReferenceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public long CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public long SalesmanId { get; set; }
        public SalesmanModel Salesman { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public PayMode PaymentMethod { get; set; }
        public bool GoodsDelivered { get; set; }
        public virtual ICollection<PaymentReceiptModel> Payments { get; set; }
    }
}
