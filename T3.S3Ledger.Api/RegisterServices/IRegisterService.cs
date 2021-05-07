using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace T3.S3Ledger.Api.RegisterServices
{
    internal interface IRegisterService
    {
        void RegisterServices(IServiceCollection services, IConfiguration configuration);
    }
}
