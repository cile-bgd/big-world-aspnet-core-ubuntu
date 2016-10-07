using Microsoft.AspNetCore.Mvc;

namespace BigWorld
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}