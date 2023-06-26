using Microsoft.AspNetCore.Mvc;

namespace Bd.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
