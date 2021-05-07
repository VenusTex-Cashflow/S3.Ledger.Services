using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Invoice
{
    internal class GetInvoiceByIdQuery : IRequest<InvoiceModel>
    {
        public int Id { get; set; }

    }
}
