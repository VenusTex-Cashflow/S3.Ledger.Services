using System.ComponentModel.DataAnnotations.Schema;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryInvestor { get; set; }
        public string OrganizationCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
