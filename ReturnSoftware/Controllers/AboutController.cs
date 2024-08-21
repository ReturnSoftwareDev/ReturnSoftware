using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.Controllers;
public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
