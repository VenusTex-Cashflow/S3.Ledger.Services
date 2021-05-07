using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Customer
{
    internal class GetPaymentReceiptByIdQueryHandler : IRequestHandler<GetPaymentReceiptByIdQuery, PaymentReceiptModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPaymentReceiptByIdQueryHandler(IMapper mapper, ICustomerRepository unitOfWork)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }

        public async Task<PaymentReceiptModel> Handle(GetPaymentReceiptByIdQuery request, CancellationToken cancellationToken)
        {
            var paymentReceipts = await _unitOfWork.PaymentReceipt.GetAsync(request.Id);

            return _mapper.Map<PaymentReceiptModel>(paymentReceipts);
        }

    }
}
