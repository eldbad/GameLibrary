using System.Linq.Expressions;
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

    public IEnumerable<Game> GetGame(int id)
    {
        return UnitOfWork.Games.FindByCondition(x => x.Id == id);
    }

    public IEnumerable<Game> GetGamesByGenre(Genre genre)
    {
        return UnitOfWork.Games.FilterByGenre(genre);
    }

    public IEnumerable<Game> GetListOfGames()
    {
        return UnitOfWork.Games.FindByCondition(x => true);
    }

    public void AddGame(Game game)
    {
        UnitOfWork.Games.Create(game);
    }

    public void DeleteGame(Game game)
    {
        UnitOfWork.Games.Delete(game);
    }
}