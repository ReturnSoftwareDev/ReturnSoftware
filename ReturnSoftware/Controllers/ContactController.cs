using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.Controllers;
public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
