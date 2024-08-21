using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _BreadCrumbComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
