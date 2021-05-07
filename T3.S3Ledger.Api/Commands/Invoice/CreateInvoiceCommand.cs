using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Invoice
{
    internal class CreateInvoiceCommand : IRequest<InvoiceModel>
    {
        public InvoiceModel Invoice { get; set; }
    }
}
