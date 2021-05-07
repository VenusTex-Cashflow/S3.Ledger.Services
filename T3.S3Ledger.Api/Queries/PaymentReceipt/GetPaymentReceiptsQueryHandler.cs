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
    internal class GetPaymentReceiptsQueryHandler : IRequestHandler<GetPaymentReceiptsQuery, IEnumerable<PaymentReceiptModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPaymentReceiptsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<PaymentReceiptModel>> Handle(GetPaymentReceiptsQuery request, CancellationToken cancellationToken)
        {
            var paymentReceipts = await _unitOfWork.PaymentReceipt.GetAllAsync();
            return _mapper.Map<IEnumerable<PaymentReceiptModel>>(paymentReceipts);
        }
    }
}
