using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Entities;
using T3.S3Ledger.Api.Data.Repository;
using T3.S3Ledger.Api.Data.Repository.Interface;

namespace T3.S3Ledger.Api.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Country = new Repository<Country>(_dbContext);
            Organization = new OrganizationRepository(_dbContext);
            Customer = new CustomerRepository(_dbContext);
            Cheque = new Repository<Cheque>(_dbContext);
            Invoice = new Repository<Invoice>(_dbContext);
            PaymentReceipt = new Repository<PaymentReceipt>(_dbContext);
            Salesman = new Repository<Salesman>(_dbContext);
            SystemUser = new Repository<SystemUser>(_dbContext);
            User = new Repository<User>(_dbContext);
        }

        public IRepository<Country> Country { get; private set; }
        public IOrganizationRepository Organization { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public IRepository<Cheque> Cheque { get; private set; }
        public IRepository<Invoice> Invoice { get; private set; }
        public IRepository<PaymentReceipt> PaymentReceipt { get; private set; }
        public IRepository<Salesman> Salesman { get; private set; }
        public IRepository<SystemUser> SystemUser { get; private set; }
        public IRepository<User> User { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
