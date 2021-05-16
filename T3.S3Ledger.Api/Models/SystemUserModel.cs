using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public class SystemUserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role? Role { get; set; }
        public int RootOrgId { get; set; }
        public OrganizationModel? Organization { get; set; }
    }
}
