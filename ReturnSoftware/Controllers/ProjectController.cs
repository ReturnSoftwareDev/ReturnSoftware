using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.Controllers;
public class ProjectController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
