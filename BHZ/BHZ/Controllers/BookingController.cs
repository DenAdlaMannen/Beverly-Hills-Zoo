using BHZ.Data;
using BHZ.Models.VisitVisitor;
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
                var animals = _context.Animals.ToList();
                var bookings = _context.Visits.Include("Visitor").Where(x => x.Id == visitorId);

                    ViewBag.Animals = animals;
                    ViewBag.Bookings = bookings;

                return View(visitor);
            }
            return RedirectToAction("VisitorView");
        }
        [HttpPost]
        public IActionResult BookAVisitAction(int visitorID, int[] selectedAnimalsId, string selectedTime, DateTime selectedDate, int selectCompanyCount)
        {
            var visitor = _context.Visitors.Find(visitorID);

            if (visitor != null)
            {
                var animals = _context.Animals.Where(x => selectedAnimalsId.Contains(x.ID)).ToList();
                Visit visit = new Visit();
                visit.Visitor = visitor;
                visit.VisitTime = selectedTime;
                visit.DateToVisit = selectedDate;
                visit.CompanyCount = selectCompanyCount;
                visit.AnimalVisit = ;

                _context.Visits.Add(visit);
                _context.SaveChanges();
                return RedirectToAction("BookAVisit", new {visitorID = visitorID});
            }
            return RedirectToAction("VisitorView", "Visitor");
        }
    }
}
