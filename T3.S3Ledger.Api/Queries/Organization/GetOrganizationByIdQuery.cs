using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.Organization
{
    public class GetOrganizationByIdQuery : IRequest<OrganizationModel>
    {
        public int Id { get; set; }
    }
}
