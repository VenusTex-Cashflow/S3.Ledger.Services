using MediatR;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.User
{
    internal class GetUserByIdQuery : IRequest<UserModel>
    {
        public int Id { get; set; }

    }
}
