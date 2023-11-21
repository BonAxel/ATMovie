using Microsoft.AspNetCore.Mvc;

namespace ATMovie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
