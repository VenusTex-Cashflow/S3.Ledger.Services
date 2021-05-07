using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace T3.S3Ledger.Api.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySQL<AppDbContext>("server=localhost;user id=mysql;password=2wsxXSW@;database=s3ledgerdb;port=3306");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
