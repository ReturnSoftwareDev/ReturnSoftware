using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _ContactComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
