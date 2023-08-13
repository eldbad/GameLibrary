using GameLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Application.Common;

public interface IAppDbContext
{
    DbSet<Game> Games { get; }
    DbSet<Genre> Genres { get; }

    DbSet<T> Set<T>() where T : class;
    int SaveChanges();
    void Dispose();
}