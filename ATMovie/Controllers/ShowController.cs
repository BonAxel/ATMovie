using Microsoft.AspNetCore.Mvc;

namespace ATMovie.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
