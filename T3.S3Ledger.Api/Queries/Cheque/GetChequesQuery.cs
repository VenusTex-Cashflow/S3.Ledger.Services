using MediatR;
using System.Collections.Generic;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Cheque
{
    internal class GetChequesQuery : IRequest<IEnumerable<ChequeModel>>
    {

    }
}
