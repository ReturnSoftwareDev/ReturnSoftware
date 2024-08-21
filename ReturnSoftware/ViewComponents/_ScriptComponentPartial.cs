using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _ScriptComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
