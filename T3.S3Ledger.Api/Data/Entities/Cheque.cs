using System;
using System.ComponentModel.DataAnnotations.Schema;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class Cheque : BaseOrgEntity
    {
        public string BankName { get; set; }
        public string Payee { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PDCDate { get; set; }
        public ChequeType ChequeType { get; set; }
        public string ChequeNumber { get; set; }
        public decimal Amount { get; set; }
        public long CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public bool IsRealized { get; set; }
        public bool IsBadCheque { get; set; }
    }
}