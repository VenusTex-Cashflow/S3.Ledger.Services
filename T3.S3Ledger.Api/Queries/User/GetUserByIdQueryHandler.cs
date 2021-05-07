using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using T3.S3Ledger.Api.Data.Repository.Interface;
using T3.S3Ledger.Api.Models;

namespace T3.S3Ledger.Api.Queries.User
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }

        public async Task<UserModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.User.GetAsync(request.Id);

            return _mapper.Map<UserModel>(customer);
        }

    }
}
