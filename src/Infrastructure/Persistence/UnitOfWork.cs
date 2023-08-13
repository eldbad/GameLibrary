using GameLibrary.Application.Common;
using GameLibrary.Application.Repositories;
using GameLibrary.Infrastructure.Persistence.Repositories;

namespace GameLibrary.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly IAppDbContext _dbContext;
    private IGameRepository? _games;
    public IGameRepository Games
    {
        get { return _games ??= new GameRepository(_dbContext); }
    }

    public UnitOfWork(IAppDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    
    public void Save()
    {
        _dbContext.SaveChanges();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}