using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Salesman
{
    internal class CreateSalesmanCommandHandler : IRequestHandler<CreateSalesmanCommand, SalesmanModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateSalesmanCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<SalesmanModel> Handle(CreateSalesmanCommand request, CancellationToken cancellationToken)
        {
            var salesman = _mapper.Map<Data.Entities.Salesman>(request.Salesman);
            await _unitOfWork.Salesman.AddAsync(salesman);
            var result = await _unitOfWork.SaveAsync();
            request.Salesman.Id = salesman.Id;
            return request.Salesman;
        }
    }
}
