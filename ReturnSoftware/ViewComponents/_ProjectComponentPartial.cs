using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _ProjectComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
