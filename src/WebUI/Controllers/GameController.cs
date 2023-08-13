using GameLibrary.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.WebUI.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : Controller
{
    private GameService GameService { get; set; }
    
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
}