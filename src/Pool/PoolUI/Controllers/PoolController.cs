using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class PoolController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
