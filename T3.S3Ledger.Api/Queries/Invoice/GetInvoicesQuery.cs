using MediatR;
using System.Collections.Generic;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Invoice
{
    internal class GetInvoicesQuery : IRequest<IEnumerable<InvoiceModel>>
    {

    }
}
