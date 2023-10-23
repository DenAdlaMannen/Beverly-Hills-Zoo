using BHZ.Data;
using BHZ.Models;
using BHZ.Models.AirAnimals;
using BHZ.Models.LandAnimals;
using BHZ.Models.WaterAnimals;
using BHZ.Models.VisitVisitor;
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

        public IActionResult AddVisitor()
        {
            var visitors = _context.Visitors.ToList();
            return View(visitors);
        }

        public IActionResult AddVisitorAction(string  name, string email)
        {

                Visitor newVisitor = new Visitor
                {
                    Name = name,
                    Email = email
                };


            _context.Visitors.Add(newVisitor);


            _context.SaveChanges();
            return RedirectToAction("VisitorView");
        }





        [HttpPost]
        public IActionResult DeleteVisitor(int VisitorID)
        {

            var visitor = _context.Visitors.Find(VisitorID);

            if (visitor != null)
            {
                _context.Visitors.Remove(visitor);
                _context.SaveChanges();
            }

            return RedirectToAction("VisitorView");
        }

        public IActionResult UpdateVisitor(int visitorID)
        {
            var visitorToUpdate = _context.Visitors.Find(visitorID);
            return View(visitorToUpdate);
        }

        public IActionResult UpdateVisitorAction(string name, string email, int visitorID)
        {

            var visitorToUpdate = _context.Visitors.Find(visitorID);

            if (visitorToUpdate != null)
            {
                visitorToUpdate.Name = name;
                visitorToUpdate.Email = email;
            }



            _context.SaveChanges();


            return RedirectToAction("VisitorView");
        }


    }
}