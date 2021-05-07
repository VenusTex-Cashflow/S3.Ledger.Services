using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.PaymentReceipt
{
    internal class CreatePaymentReceiptCommandHandler : IRequestHandler<CreatePaymentReceiptCommand, PaymentReceiptModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreatePaymentReceiptCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<PaymentReceiptModel> Handle(CreatePaymentReceiptCommand request, CancellationToken cancellationToken)
        {
            var paymentReceipt = _mapper.Map<Data.Entities.PaymentReceipt>(request.PaymentReceipt);
            await _unitOfWork.PaymentReceipt.AddAsync(paymentReceipt);
            var result = await _unitOfWork.SaveAsync();
            request.PaymentReceipt.Id = paymentReceipt.Id;
            return request.PaymentReceipt;
        }
    }
}
