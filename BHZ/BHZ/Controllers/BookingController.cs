using BHZ.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BHZ.Controllers
{
    public class BookingController : Controller
    {
        private readonly BhzDbContext _context;

        public BookingController(BhzDbContext context)
        {
            _context = context;
        }
        public IActionResult BookAVisit(int visitorId)
        {
            var visitor = _context.Visitors.Find(visitorId);

            if(visitor != null)
            {
                return View(visitor);
            }


            return RedirectToAction("VisitorView");
        }
        public IActionResult DeleteAnimal(int animalID)
        {

            var animal = _context.Animals.Find(animalID);

            if (animal != null)
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
            }

            return RedirectToAction("AnimalView");
        }
    }
}
