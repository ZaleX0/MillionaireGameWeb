using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MillionaireWeb.Entities;
using MillionaireWeb.Models;
using MillionaireWeb.Services;

namespace MillionaireWeb.Controllers;
public class GameController : Controller
{
    private readonly IGameService _service;

    public GameController(IGameService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var model = _service.NextGameViewModel(0);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult Index(GameViewModel model)
    {
        model = _service.ResultGameViewModel(model);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult Next(int prizeLevel)
    {
        var model = _service.NextGameViewModel(prizeLevel);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult GameOver(int prizeLevel, bool isResigned)
    {
        int prizeLevelAmount = isResigned
            ? _service.GetPreviousPrizeLevelAmount(prizeLevel)
            : _service.GetPreviousGuaranteedPrizeLevelAmount(prizeLevel);

        return View("GameOver", prizeLevelAmount);
    }

    [HttpPost]
    public IActionResult GameWon()
    {
        int prizeLevelAmount = _service.GetWinningPrizeAmount();
        return View("GameOver", prizeLevelAmount);
    }
}
