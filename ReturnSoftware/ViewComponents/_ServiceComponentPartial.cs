using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _ServiceComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
