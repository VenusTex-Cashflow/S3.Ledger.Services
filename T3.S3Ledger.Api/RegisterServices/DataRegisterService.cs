using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using T3.S3Ledger.Api.Data;
using T3.S3Ledger.Api.Data.Initializer;
using T3.S3Ledger.Api.Data.Repository;
using T3.S3Ledger.Api.Data.Repository.Interface;

namespace T3.S3Ledger.Api.RegisterServices
{
    public class DataRegisterService : IRegisterService
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddDbContext<AppDbContext>(option => option.UseMySQL(configuration.GetConnectionString("Db")));
        }
    }
}
