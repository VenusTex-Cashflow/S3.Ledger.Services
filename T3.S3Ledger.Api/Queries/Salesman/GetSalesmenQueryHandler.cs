using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Salesman
{
    internal class GetSalesmenQueryHandler : IRequestHandler<GetSalesmenQuery, IEnumerable<SalesmanModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSalesmenQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<SalesmanModel>> Handle(GetSalesmenQuery request, CancellationToken cancellationToken)
        {
            var salesmen = await _unitOfWork.Salesman.GetAllAsync();
            return _mapper.Map<IEnumerable<SalesmanModel>>(salesmen);
        }
    }
}
