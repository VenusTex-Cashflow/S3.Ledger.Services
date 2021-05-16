using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using T3.S3Ledger.Api.Data.Configurations;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public IConfiguration Configuration { get; private set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Cheque> Cheque { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<PaymentReceipt> PaymentReceipt { get; set; }
        public DbSet<Salesman> Salesman { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Configuration.GetConnectionString("Db"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new OrganizationConfiguration());
            modelBuilder.AddConfiguration(new CountryConfiguration());
            modelBuilder.AddConfiguration(new CustomerConfiguration());
            modelBuilder.AddConfiguration(new SalesmanConfiguration());
        }
    }
}
