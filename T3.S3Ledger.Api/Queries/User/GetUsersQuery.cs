using MediatR;
using System.Collections.Generic;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.User
{
    internal class GetUsersQuery : IRequest<IEnumerable<UserModel>>
    {

    }
}
