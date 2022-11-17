using Microsoft.AspNetCore.Mvc;
using MillionaireWeb.Models;
using MillionaireWeb.Services;

namespace MillionaireWeb.Controllers;
public class QuestionsController : Controller
{
    private readonly IQuestionsService _service;

    public QuestionsController(IQuestionsService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        int count = _service.GetPrizeLevelCount();
        return View(count);
    }

    [HttpPost]
    public IActionResult Index(CreateQuestionDto dto)
    {
        _service.AddQuestion(dto);
        int count = _service.GetPrizeLevelCount();
        return View(count);
    }
}
