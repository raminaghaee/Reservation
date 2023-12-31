using Microsoft.AspNetCore.Mvc;

namespace PoolUI.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
