using Microsoft.AspNetCore.Mvc;

namespace ATMovie.Controllers
{
    public class RowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
