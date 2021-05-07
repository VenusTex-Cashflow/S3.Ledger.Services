using System.ComponentModel.DataAnnotations;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class Salesman : BaseOrgEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}