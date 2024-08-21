using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.Controllers;
public class ServiceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
