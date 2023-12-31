using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class ReservedController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
