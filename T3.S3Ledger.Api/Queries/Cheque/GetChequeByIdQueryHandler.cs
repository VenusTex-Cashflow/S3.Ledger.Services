using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Cheque
{
    internal class GetChequeByIdQueryHandler : IRequestHandler<GetChequeByIdQuery, ChequeModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetChequeByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }

        public async Task<ChequeModel> Handle(GetChequeByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Cheque.GetAsync(request.Id);

            return _mapper.Map<ChequeModel>(customer);
        }

    }
}
