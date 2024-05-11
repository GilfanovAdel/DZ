using Microsoft.EntityFrameworkCore;
using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Domain.Entities;

namespace TeamHost.Persistence.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly IGenericRepository<Game> _repository;

        public GameRepository(IGenericRepository<Game> repository)
        {
            _repository = repository;
        }

    }
}
