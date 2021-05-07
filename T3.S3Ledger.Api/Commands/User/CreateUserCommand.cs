using MediatR;
using T3.S3Ledger.Api.Models;


namespace T3.S3Ledger.Api.Commands.User
{
    internal class CreateUserCommand : IRequest<UserModel>
    {
        public UserModel User { get; set; }
    }
}
