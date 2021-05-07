using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder
                .ToTable("Customer")
                .HasKey(c => c.Id);
        }
    }
}
