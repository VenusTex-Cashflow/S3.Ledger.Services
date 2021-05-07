using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Configurations
{
    public class OrganizationConfiguration : EntityTypeConfiguration<Organization>
    {
        public override void Map(EntityTypeBuilder<Organization> modelBuilder)
        {
            modelBuilder
                .ToTable("Organization")
                .HasKey(c => c.Id);

            modelBuilder
                .HasData(
                    new Organization { Id = 1, Name = "TrueThink", OrganizationCode = "T3", CountryId = 200 }
                );
        }
    }
}
