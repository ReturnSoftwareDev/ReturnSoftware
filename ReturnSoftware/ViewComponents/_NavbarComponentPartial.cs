﻿using Microsoft.AspNetCore.Mvc;

namespace ReturnSoftware.ViewComponents;

public class _NavbarComponentPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
