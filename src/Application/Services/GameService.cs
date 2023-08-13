using GameLibrary.Application.Common;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Application.Services;

public class GameService
{
    private IUnitOfWork UnitOfWork { get; set; }
    
    public GameService(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public IQueryable<Game> GetGame(int id)
    {
        return UnitOfWork.Games.FindByCondition(x => x.Id == id);
    }
}