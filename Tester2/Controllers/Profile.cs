using Microsoft.AspNetCore.Mvc;

namespace Tester2.Controllers
{
    public class Profile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
