using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.PaymentReceipt
{
    internal class CreatePaymentReceiptCommand : IRequest<PaymentReceiptModel>
    {
        public PaymentReceiptModel PaymentReceipt { get; set; }
    }
}
