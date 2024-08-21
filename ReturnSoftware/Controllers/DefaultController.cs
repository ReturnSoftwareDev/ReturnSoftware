using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.Controllers;
public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
