﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public partial class Invoice : BaseOrgEntity
    {
        public string ReferenceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public long CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public long SalesmanId { get; set; }
        [ForeignKey("SalesmanId")]
        public Salesman Salesman { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public PayMode PaymentMethod { get; set; }
        public bool GoodsDelivered { get; set; }
        public virtual ICollection<PaymentReceipt> Payments { get; set; }
    }
}