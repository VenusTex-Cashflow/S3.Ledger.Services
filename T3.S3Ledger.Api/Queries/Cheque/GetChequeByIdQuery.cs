using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Cheque
{
    internal class GetChequeByIdQuery : IRequest<ChequeModel>
    {
        public int Id { get; set; }

    }
}
