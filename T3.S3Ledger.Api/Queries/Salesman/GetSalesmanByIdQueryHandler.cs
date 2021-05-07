using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Salesman
{
    internal class GetSalesmanByIdQueryHandler : IRequestHandler<GetSalesmanByIdQuery, SalesmanModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSalesmanByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }

        public async Task<SalesmanModel> Handle(GetSalesmanByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Salesman.GetAsync(request.Id);

            return _mapper.Map<SalesmanModel>(customer);
        }

    }
}
