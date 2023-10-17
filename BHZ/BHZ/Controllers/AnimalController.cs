using Microsoft.AspNetCore.Mvc;

namespace BHZ.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult AnimalView()
        {
            return View();
        }
    }
}
