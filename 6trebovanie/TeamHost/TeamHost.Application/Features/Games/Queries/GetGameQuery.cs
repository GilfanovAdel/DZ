using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHost.Application.Features.Games.DTOs;

namespace TeamHost.Application.Features.Games.Queries
{
    public record GetGameQuery(int Id) : IRequest<GetAllGamesResponse>;
}
