using GameLibrary.Application.Services;
using GameLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.WebUI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController : Controller
{
    private GameService GameService { get; }
    
    public GameController(GameService gameService)
    {
        GameService = gameService;
    }

    [HttpGet]
    public IActionResult GetGames(int id)
    {
        var result = GameService.GetGame(id);
        
        return Json(result);
    }

    [HttpGet]
    public IActionResult GetGamesByGenre(Genre genre)
    {
        var result = GameService.GetGamesByGenre(genre);

        return Json(result);
    }

    [HttpGet]
    public IActionResult GetListOfGames()
    {
        var result = GameService.GetListOfGames();

        return Json(result);
    }

    [HttpPost]
    public IActionResult AddGame(Game game)
    {
        GameService.AddGame(game);
        
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteGame(Game game)
    {
        GameService.DeleteGame(game);

        return Ok();
    }
}