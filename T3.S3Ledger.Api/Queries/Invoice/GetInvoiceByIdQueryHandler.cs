using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Invoice
{
    internal class GetInvoiceByIdQueryHandler : IRequestHandler<GetInvoiceByIdQuery, InvoiceModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInvoiceByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }

        public async Task<InvoiceModel> Handle(GetInvoiceByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Invoice.GetAsync(request.Id);

            return _mapper.Map<InvoiceModel>(customer);
        }

    }
}
