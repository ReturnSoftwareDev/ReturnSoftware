using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _TestimonialComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
