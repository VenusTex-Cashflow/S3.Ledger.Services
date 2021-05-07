using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Customer
{
    internal class CreateCustomerCommand : IRequest<CustomerModel>
    {
        public CustomerModel Customer { get; set; }
    }
}
