using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public class AddressModel
    {
        public long Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? CountryId { get; set; }
        public AddressType? AddressType { get; set; }
        public int? CustomerId { get; set; }
    }
}
