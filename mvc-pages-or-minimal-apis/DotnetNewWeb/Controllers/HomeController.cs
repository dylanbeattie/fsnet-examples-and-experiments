using DotnetNewWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetNewMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new HelloModel(DateTimeOffset.Now);
        return View(model);
    }
}
