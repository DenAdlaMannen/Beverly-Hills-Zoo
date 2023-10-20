using Microsoft.AspNetCore.Mvc;

namespace BHZ.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
