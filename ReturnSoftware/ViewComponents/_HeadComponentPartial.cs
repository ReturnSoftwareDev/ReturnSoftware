using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _HeadComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
