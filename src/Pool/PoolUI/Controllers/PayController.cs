using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class PayController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
