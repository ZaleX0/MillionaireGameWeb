using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MillionaireWeb.Entities;
using MillionaireWeb.Models;
using MillionaireWeb.Services;

namespace MillionaireWeb.Controllers;
public class GameController : Controller
{
    private readonly GameService _service;

    public GameController(GameService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var model = _service.NextGameViewModel(new GameViewModel());
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(GameViewModel model)
    {
        model = _service.ResultGameViewModel(model);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult NextIndex(GameViewModel model)
    {
        model = _service.NextGameViewModel(model);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult GameOver(GameViewModel model)
    {
        return View("GameOver", model);
    }
}
