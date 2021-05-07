using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Customer
{
    internal class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, IEnumerable<CustomerModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<CustomerModel>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _unitOfWork.Customer.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerModel>>(customers);
        }
    }
}
