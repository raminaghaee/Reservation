using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class ConstantController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
