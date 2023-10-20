using BHZ.Data;
using BHZ.Models;
using BHZ.Models.AirAnimals;
using BHZ.Models.LandAnimals;
using BHZ.Models.WaterAnimals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BHZ.Controllers
{
    public class VisitorController : Controller
    {

        private readonly BhzDbContext _context;
        public VisitorController(BhzDbContext context)
        {
            _context = context;
        }
        public IActionResult VisitorView()
        {
            var visitors = _context.Visitors.ToList();
            return View(visitors);
        }
        public IActionResult AddAnimal()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }
    }
}
