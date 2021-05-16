using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Entities;
using T3.S3Ledger.Api.Data.Repository.Interface;
using static T3.S3Ledger.Api.Enums;

namespace T3.S3Ledger.Api.Data.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly AppDbContext _dbContext;

        public InvoiceRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task<IList<Invoice>> GetInvoiceByCustomer(long customerId, InvoiceStatus status)
        //{
        //    var invoices = _dbContext.Invoice.Where(c => c.CustomerId == customerId && c.InvoiceStatus == status).ToList();
        //    return await Task.Run(() => invoices);
        //}
    }
}
