using Microsoft.AspNetCore.Mvc;

namespace IOApp.Controllers
{
    public class MainController : Controller
    {
        public MainController()
        {
                
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
