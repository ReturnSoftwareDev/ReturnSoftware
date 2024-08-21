using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
