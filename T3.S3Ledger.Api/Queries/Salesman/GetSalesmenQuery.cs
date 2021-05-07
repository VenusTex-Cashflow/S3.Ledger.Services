using MediatR;
using System.Collections.Generic;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Salesman
{
    internal class GetSalesmenQuery : IRequest<IEnumerable<SalesmanModel>>
    {

    }
}
