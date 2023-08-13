using GameLibrary.Application.Common;
using GameLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }
}