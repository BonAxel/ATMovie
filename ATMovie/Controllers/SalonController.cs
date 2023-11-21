using Microsoft.AspNetCore.Mvc;

namespace ATMovie.Controllers
{
    public class SalonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
