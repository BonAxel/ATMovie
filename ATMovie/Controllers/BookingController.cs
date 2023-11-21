using Microsoft.AspNetCore.Mvc;

namespace ATMovie.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
