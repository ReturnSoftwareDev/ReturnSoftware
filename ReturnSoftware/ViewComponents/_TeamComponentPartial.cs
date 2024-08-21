using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _TeamComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
