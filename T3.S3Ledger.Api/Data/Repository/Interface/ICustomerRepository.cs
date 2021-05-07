using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Repository.Interface
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //List<Customer> GetByName(string firstName, string lastName);

        //Customer GetByMobile(string mobileNo);
    }
}
