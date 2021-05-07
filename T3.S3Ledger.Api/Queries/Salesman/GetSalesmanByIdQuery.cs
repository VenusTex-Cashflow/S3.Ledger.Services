using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Salesman
{
    internal class GetSalesmanByIdQuery : IRequest<SalesmanModel>
    {
        public int Id { get; set; }

    }
}
