using AutoMapper;
using MediatR;
using TeamHost.Application.Features.Account.Commands;
using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Features.Account.Handlers
{
    public class SaveProfileHandler : IRequestHandler<SaveProfile, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SaveProfileHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(SaveProfile request, CancellationToken cancellationToken)
        {
            await _unitOfWork.Repository<User>().AddAsync(new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Patronimic = request.Patronimic,
                About = request.About,
                Birthday = request.Birthday,
                IdentityUserId = request.IdentityUserId
            });

            return true;
        }
    }
}
