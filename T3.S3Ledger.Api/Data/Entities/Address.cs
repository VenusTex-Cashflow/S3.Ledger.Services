using System.ComponentModel.DataAnnotations.Schema;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class Address
    {
        public long Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public AddressType? AddressType { get; set; }
        public long? CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }
    }
}
