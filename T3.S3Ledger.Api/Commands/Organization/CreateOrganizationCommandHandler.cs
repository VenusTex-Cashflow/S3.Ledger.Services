using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Organization
{
    internal class CreateOrganizationCommandHandler : IRequestHandler<CreateOrganizationCommand, OrganizationModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateOrganizationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<OrganizationModel> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = _mapper.Map<Data.Entities.Organization>(request.Organization);
            await _unitOfWork.Organization.AddAsync(organization);
            var result = await _unitOfWork.SaveAsync();
            request.Organization.Id = organization.Id;
            return request.Organization;
        }
    }
}
