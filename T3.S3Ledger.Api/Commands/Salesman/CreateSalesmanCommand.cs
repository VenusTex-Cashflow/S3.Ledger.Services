using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Salesman
{
    internal class CreateSalesmanCommand : IRequest<SalesmanModel>
    {
        public SalesmanModel Salesman { get; set; }
    }
}
