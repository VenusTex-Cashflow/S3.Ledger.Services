using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Customer
{
    internal class GetCustomerByIdQuery : IRequest<CustomerModel>
    {
        public int Id { get; set; }

    }
}
