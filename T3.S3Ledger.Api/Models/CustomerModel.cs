using System.Collections.Generic;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public partial class CustomerModel : BaseOrgModel
    {
        public CustomerType? CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string MobileNumber { get; set; }
        public string OtherContactNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string Email { get; set; }
        public BusinessType? BusinessType { get; set; }
        public decimal? TotalOutstandingAmount { get; set; }
        public decimal? TotalInvoicedAmount { get; set; }
        public decimal? TotalAmountSettled { get; set; }

        public virtual ICollection<AddressModel>? Addresses { get; set; }
        public virtual ICollection<InvoiceModel> Invoices { get; set; }
        public virtual ICollection<PaymentReceiptModel> PaymentReceipts { get; set; }
    }

}
