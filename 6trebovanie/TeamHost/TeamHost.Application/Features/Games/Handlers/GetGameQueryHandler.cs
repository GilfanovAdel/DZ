using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHost.Application.Features.Games.DTOs;
using TeamHost.Application.Features.Games.Queries;
using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Domain.Entities;

namespace TeamHost.Application.Features.Games.Handlers
{
    public class GetGameQueryHandler : IRequestHandler<GetGameQuery, GetAllGamesResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetGameQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetAllGamesResponse> Handle(GetGameQuery request, CancellationToken cancellationToken)
        {
            var games = await _unitOfWork.Repository<Game>().Entities.Where(x => x.Id == request.Id)

                    .ProjectTo<GetAllGamesResponse>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return games;
        }
    }
}
