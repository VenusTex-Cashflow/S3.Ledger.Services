using System.ComponentModel.DataAnnotations.Schema;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class InvoicePaymentReceipt
    {
        public long InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
        public int PaymentReceiptId { get; set; }
        [ForeignKey("PaymentReceiptId")]
        public PaymentReceipt PaymentReceipt { get; set; }
    }
}
