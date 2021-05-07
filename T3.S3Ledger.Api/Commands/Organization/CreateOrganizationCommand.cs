using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Commands.Organization
{
    internal class CreateOrganizationCommand : IRequest<OrganizationModel>
    {
        public OrganizationModel Organization { get; set; }
    }
}
