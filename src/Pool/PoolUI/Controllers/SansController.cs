using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class SansController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
