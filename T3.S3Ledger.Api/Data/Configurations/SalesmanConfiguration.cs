using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Configurations
{
    public class SalesmanConfiguration : EntityTypeConfiguration<Salesman>
    {
        public override void Map(EntityTypeBuilder<Salesman> modelBuilder)
        {
            modelBuilder
                .ToTable("Salesman")
                .HasKey(c => c.Id);

            modelBuilder
                .HasData(
                    new Salesman { Id = 1, FirstName = "TrueThink", LastName = "Salesman", MobileNumber = "0772345001", OrganizationId = 1 }
                );
        }
    }
}
