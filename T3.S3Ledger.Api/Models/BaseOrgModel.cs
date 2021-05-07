namespace T3.S3Ledger.Api.Models
{
    public abstract class BaseOrgModel : BaseModel
    {
        public int OrganizationId { get; set; }
        public OrganizationModel Organization { get; set; }
    }
}
