using GameLibrary.Application.Common;
using GameLibrary.Application.Repositories;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Infrastructure.Persistence.Repositories;

public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
{
    public GenreRepository(IAppDbContext dbContext) : base(dbContext)
    {
    }
}