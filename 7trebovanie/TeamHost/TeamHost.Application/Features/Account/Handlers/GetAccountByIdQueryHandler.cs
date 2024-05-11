using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TeamHost.Application.Features.Account.DTOs;
using TeamHost.Application.Features.Account.Queries;
using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Features.Account.Handlers
{
    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, AccountDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAccountByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<AccountDto> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Repository<User>().Entities.Where(x => x.IdentityUserId == request.Id)

                    .ProjectTo<AccountDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return user;
        }

    }
}
