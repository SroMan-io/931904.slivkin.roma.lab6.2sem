using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
