using GameLibrary.Application.Common;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Application.Repositories;

public interface IGameRepository : IRepository<Game>
{
    IQueryable<Game> FilterByGenre(Genre genre);
}