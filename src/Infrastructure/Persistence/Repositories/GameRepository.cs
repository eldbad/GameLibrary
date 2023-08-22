using GameLibrary.Application.Common;
using GameLibrary.Application.Repositories;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Infrastructure.Persistence.Repositories;

public class GameRepository : RepositoryBase<Game>, IGameRepository
{
    public GameRepository(IAppDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Game> FilterByGenre(Genre genre)
    {
        return DbContext.Games.Where(x => x.Genre != null && x.Genre.Id == genre.Id);
    }
}