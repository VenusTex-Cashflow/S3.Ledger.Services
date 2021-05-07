using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Invoice
{
    internal class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, InvoiceModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateInvoiceCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<InvoiceModel> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            var invoice = _mapper.Map<Data.Entities.Invoice>(request.Invoice);
            await _unitOfWork.Invoice.AddAsync(invoice);
            var result = await _unitOfWork.SaveAsync();
            request.Invoice.Id = invoice.Id;
            return request.Invoice;
        }
    }
}
