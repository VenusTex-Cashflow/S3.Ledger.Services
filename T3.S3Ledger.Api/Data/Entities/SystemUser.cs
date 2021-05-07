using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Role Role { get; set; }
        public int RootOrgId { get; set; }
        [ForeignKey("RootOrgId")]
        public Organization Organization { get; set; }
    }
}
