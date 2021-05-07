using System.Linq;
using T3.S3Ledger.Api.Data.Entities;
using T3.S3Ledger.Api.Data.Repository.Interface;

namespace T3.S3Ledger.Api.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _dbContext;

        public CustomerRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        //public Customer GetByMobile(string mobileNo)
        //{
        //    return _dbContext.Customer.Where(c => c.MobileNumber == mobileNo).FirstOrDefault() ?? null;

        //}

        //public List<Customer> GetByName(string? firstName, string? lastName)
        //{
        //    return _dbContext.Customer.Where(c => c.FirstName.Contains(firstName) || c.LastName.Contains(lastName)).ToList() ?? null;
        //}

    }
}
