using BHZ.Data;
using Microsoft.AspNetCore.Mvc;

namespace BHZ.Controllers
{
    public class AnimalController : Controller
    {
        private readonly BhzDbContext _context;
        public AnimalController(BhzDbContext context)
        {
            _context = context;
        }
        public IActionResult AnimalView()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }
    }
}
