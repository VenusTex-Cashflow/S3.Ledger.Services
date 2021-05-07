using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Cheque
{
    internal class GetChequesQueryHandler : IRequestHandler<GetChequesQuery, IEnumerable<ChequeModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetChequesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<ChequeModel>> Handle(GetChequesQuery request, CancellationToken cancellationToken)
        {
            var cheques = await _unitOfWork.Cheque.GetAllAsync();
            return _mapper.Map<IEnumerable<ChequeModel>>(cheques);
        }
    }
}
