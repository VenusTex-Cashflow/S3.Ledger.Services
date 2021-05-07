using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Cheque
{
    internal class CreateChequeCommand : IRequest<ChequeModel>
    {
        public ChequeModel Cheque { get; set; }
    }
}
