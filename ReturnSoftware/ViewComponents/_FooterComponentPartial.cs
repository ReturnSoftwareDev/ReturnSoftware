﻿using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _FooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
