using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Repository.Interface
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        //Task<IList<Invoice>> GetInvoiceByCustomer(long customerId, InvoiceStatus status);
    }
}
