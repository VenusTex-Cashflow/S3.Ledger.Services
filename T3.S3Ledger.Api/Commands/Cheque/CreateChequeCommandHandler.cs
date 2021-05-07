using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Cheque
{
    internal class CreateChequeCommandHandler : IRequestHandler<CreateChequeCommand, ChequeModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateChequeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<ChequeModel> Handle(CreateChequeCommand request, CancellationToken cancellationToken)
        {
            var cheque = _mapper.Map<Data.Entities.Cheque>(request.Cheque);
            await _unitOfWork.Cheque.AddAsync(cheque);
            var result = await _unitOfWork.SaveAsync();
            request.Cheque.Id = cheque.Id;
            return request.Cheque;
        }
    }
}
