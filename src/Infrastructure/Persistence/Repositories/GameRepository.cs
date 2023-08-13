using GameLibrary.Application.Common;
using GameLibrary.Application.Repositories;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Infrastructure.Persistence.Repositories;

public class GameRepository : RepositoryBase<Game>, IGameRepository
{
    public GameRepository(IAppDbContext dbContext) : base(dbContext)
    {
    }
}