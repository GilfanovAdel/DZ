using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHost.Application.Features.Account.DTOs;
using TeamHost.Application.Features.Games.DTOs;

namespace TeamHost.Application.Features.Account.Queries
{
    public class GetAccountByIdQuery : IRequest<AccountDto>
    {
        public string Id { get; set; }
    }
}
