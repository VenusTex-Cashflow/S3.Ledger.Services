using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Customer
{
    internal class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<CustomerModel> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Data.Entities.Organization>(request.Customer);
            await _unitOfWork.Organization.AddAsync(customer);
            var result = await _unitOfWork.SaveAsync();
            request.Customer.Id = customer.Id;
            return request.Customer;
        }
    }
}
