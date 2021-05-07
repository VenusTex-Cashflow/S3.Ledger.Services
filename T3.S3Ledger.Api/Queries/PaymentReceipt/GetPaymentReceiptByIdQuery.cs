using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Customer
{
    internal class GetPaymentReceiptByIdQuery : IRequest<PaymentReceiptModel>
    {
        public int Id { get; set; }

    }
}
