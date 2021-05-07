using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Organization
{
    internal class GetOrganizationByIdQueryHandler : IRequestHandler<GetOrganizationByIdQuery, OrganizationModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrganizationByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<OrganizationModel> Handle(GetOrganizationByIdQuery request, CancellationToken cancellationToken)
        {
            var organization = await _unitOfWork.Organization.GetAsync(request.Id);
            return _mapper.Map<OrganizationModel>(organization);
        }
    }
}
