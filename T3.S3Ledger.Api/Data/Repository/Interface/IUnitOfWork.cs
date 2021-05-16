using System;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Country> Country { get; }
        IOrganizationRepository Organization { get; }
        ICustomerRepository Customer { get; }
        IRepository<Cheque> Cheque { get; }
        IInvoiceRepository Invoice { get; }
        IRepository<PaymentReceipt> PaymentReceipt { get; }
        IRepository<Salesman> Salesman { get; }
        IRepository<SystemUser> SystemUser { get; }
        IRepository<User> User { get; }

        Task<int> SaveAsync();
    }
}
