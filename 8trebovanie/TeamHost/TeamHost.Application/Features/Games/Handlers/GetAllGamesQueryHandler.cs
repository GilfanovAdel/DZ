using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TeamHost.Application.Features.Games.DTOs;
using TeamHost.Application.Features.Games.Queries;
using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Features.Games.Handlers
{
    internal class GetAllPlayersQueryHandler : IRequestHandler<GetAllGamesQuery, List<GetAllGamesResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllPlayersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllGamesResponse>> Handle(GetAllGamesQuery query, CancellationToken cancellationToken)
        {
            var games = await _unitOfWork.Repository<Game>().Entities
                   .ProjectTo<GetAllGamesResponse>(_mapper.ConfigurationProvider)
                   .ToListAsync();

            return games;
        }
    }
}
