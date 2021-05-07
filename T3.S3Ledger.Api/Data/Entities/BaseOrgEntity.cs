using System.ComponentModel.DataAnnotations.Schema;

namespace T3.S3Ledger.Api.Data.Entities
{
    public abstract class BaseOrgEntity : BaseEntity
    {
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }
    }
}
