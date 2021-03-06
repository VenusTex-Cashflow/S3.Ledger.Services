using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public partial class Customer : BaseOrgEntity
    {
        public CustomerType? CustomerType { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }
        [MaxLength(20)]
        public string CompanyCode { get; set; }
        [MaxLength(10)]
        public string MobileNumber { get; set; }
        [MaxLength(10)]
        public string OtherContactNumber { get; set; }
        [MaxLength(10)]
        public string OfficeNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public BusinessType? BusinessType { get; set; }
        public decimal? TotalOutstandingAmount { get; set; }
        public decimal? TotalInvoicedAmount { get; set; }
        public decimal? TotalAmountSettled { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = null;
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }

    }

}
