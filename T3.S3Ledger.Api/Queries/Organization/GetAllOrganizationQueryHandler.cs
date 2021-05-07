using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Organization
{
    internal class GetAllOrganizationQueryHandler : IRequestHandler<GetAllOrganizationQuery, IEnumerable<OrganizationModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllOrganizationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<OrganizationModel>> Handle(GetAllOrganizationQuery request, CancellationToken cancellationToken)
        {
            var organizations = await _unitOfWork.Organization.GetAllAsync();
            return _mapper.Map<IEnumerable<OrganizationModel>>(organizations);
        }
    }
}
