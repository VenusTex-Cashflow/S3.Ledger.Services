namespace T3.S3Ledger.Api.Models
{
    public class OrganizationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryInvestor { get; set; }
        public string OrganizationCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int? CountryId { get; set; }
        public CountryModel? Country { get; set; }
    }
}
