using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Models
{
    public partial class UserModel : BaseOrgModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role? Role { get; set; }
        public bool? Verified { get; set; }
    }
}