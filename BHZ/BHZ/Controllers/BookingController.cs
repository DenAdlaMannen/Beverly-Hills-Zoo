using BHZ.Data;
using BHZ.Models;
using BHZ.Models.VisitVisitor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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

            if (visitor != null)
            {
                //Only display animals that is not occupied this 

                var animals = _context.Animals.ToList();
                var bookings = _context.Visits.Include("Animals").Where(x => x.Visitor.ID == visitorId).ToList();

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

            //Check if visitor already has a booking this time


            if (visitor != null)
            {
                var animals = _context.Animals.Where(x => selectedAnimalsId.Contains(x.ID)).ToList();
                Visit visit = new Visit();
                visit.Visitor = visitor;
                visit.VisitTime = selectedTime;
                visit.DateToVisit = selectedDate;
                visit.CompanyCount = selectCompanyCount;
                visit.Animals = animals;

                _context.Visits.Add(visit);
                _context.SaveChanges();
                return RedirectToAction("BookAVisit", new { visitorID = visitorID });
            }
            return RedirectToAction("VisitorView", "Visitor");
        }
        [HttpPost]
        public IActionResult BookAnimalAction(int visitorID, string selectedTime, DateTime selectedDate, string[] selectedAnimalSpecie, int selectCompanyCount)
        {
            var visitor = _context.Visitors.Find(visitorID);

            //Check if visitor already has a booking this time

            if (visitor != null)
            {
                List<Animal> animals = new List<Animal> { };
                //var animals = _context.Animals.Where(x => selectedAnimalSpecie.Contains(x.ID)).ToList();
                foreach (var animal in selectedAnimalSpecie)
                {
                    var animalsSelect = _context.Animals.Where(x => x.SpecieName == animal).ToList();
                    foreach (var individualAnimal in animalsSelect)
                    {
                        animals.Add(individualAnimal);
                    }
                }
                Visit visit = new Visit();
                visit.Visitor = visitor;
                visit.VisitTime = selectedTime;
                visit.DateToVisit = selectedDate;
                visit.CompanyCount = selectCompanyCount;
                visit.Animals = animals;

                _context.Visits.Add(visit);
                _context.SaveChanges();
                return RedirectToAction("BookAVisit", new { visitorID = visitorID });
            }
            return RedirectToAction("VisitorView", "Visitor");
        }
        [HttpPost]
        public IActionResult BookAnimal(int visitorID, string selectedTime, DateTime selectedDate)
        {
            List<string> animalSpecies = new List<string> { "Penguin", "Gargoyle", "Dragon", "Ant", "Hedgehog", "Snake", "Crab", "Cucumber", "Plankton" };
            List<Animal> availableAnimals = new List<Animal>();
            var visitor = _context.Visitors.Find(visitorID);

            if (visitor != null)
            {
                //Only display animals that is not occupied this 
                //foreach (var animal in animalSpecies)
                //{
                //    var animalCount2 = _context.Visits.Include("Animals").Where(x => x.VisitTime == selectedTime).Where(x => x.DateToVisit == selectedDate).Where(x => x.Animals.SpecieName == animal).Count();
                //}

                //foreach (var animalName in animalSpecies)
                //{
                //    var animals2 = _context.Animals.Where(a => a.SpecieName == animalName).ToList();

                //    foreach (var animal in animals2)
                //    {
                //        var animalCount = _context.Visits
                //            .Include("Animals")
                //            .Count(x => x.VisitTime == selectedTime &&
                //                        x.DateToVisit == selectedDate &&
                //                        x.Animals.Any(a => a.ID == animal.ID));

                //        if (animalCount < 2)
                //        {
                //            availableAnimals.Add(animal);
                //        }
                //    }
                //}

                // Find avaiable animals for selectedTime and selectedDate

                foreach (var animal in animalSpecies)
                {
                    //Does the animal specie exist more than 2 times this day, gets the count
                    var animalCount2 = _context.Visits.Include("Animals").Where(x => x.DateToVisit == selectedDate).Where(x => x.Animals.Any(a => a.SpecieName == animal)).Count();

                    var individualAnimalCount = _context.Visits.Include("Animals").Where(x => x.DateToVisit == selectedDate).Where(t => t.VisitTime == selectedTime).Where(x => x.Animals.Any(a => a.SpecieName == animal)).Count();

                    if (individualAnimalCount < 1)
                    {
                        var addAnimal = _context.Animals.FirstOrDefault(x => x.SpecieName == animal);
                        availableAnimals.Add(addAnimal);
                    }
                }



                var animalCount = _context.Visits.Include("Animals").Where(x => x.VisitTime == "Förmiddag 9-12").Where(x => x.DateToVisit == selectedDate).Count();


                var animals = _context.Animals.ToList();
                var bookings = _context.Visits.Include("Animals").Where(x => x.Visitor.ID == visitorID).Select(x => x).Distinct().ToList();
                //var bookings = _context.Visits.Include("Animals").Where(x => x.Visitor.ID == visitorID).Select(x => x).Distinct().ToList();

                ViewBag.Animals = animals;
                ViewBag.Bookings = bookings;
                ViewBag.SelectedTime = selectedTime;
                ViewBag.SelectedDate = selectedDate;
                ViewBag.AvailableAnimals = availableAnimals;

                return View(visitor);
            }
            return RedirectToAction("VisitorView");
        }
        public IActionResult DeleteBooking(int visitId)
        {

            var booking = _context.Visits.Include("Visitor").FirstOrDefault(x => x.Id == visitId);
            int visitorID = booking.Visitor.ID;

            if (booking != null)
            {
                _context.Visits.Remove(booking);
                _context.SaveChanges();
            }

            return RedirectToAction("BookAVisit", new { visitorId = visitorID });
        }
        public IActionResult UpdateBooking(int visitId)
        {
            var booking = _context.Visits.Include("Visitor").FirstOrDefault(x => x.Id == visitId);
            //ViewBag.Visitor = booking.Visitor;
            return View(booking);
        }
        public IActionResult UpdateBookedAnimal(int visitId, string selectedTime, DateTime selectedDate)
        {
            var booking = _context.Visits.Include("Visitor").FirstOrDefault(x => x.Id == visitId);
            ViewBag.AvailableAnimals = GetAvailableAnimals(selectedTime, selectedDate);
            ViewBag.SelectedTime = selectedTime;
            ViewBag.SelectedDate = selectedDate;

            return View(booking);
        }
        [HttpPost]
        public IActionResult UpdateBookedAnimalAction(int visitId, string selectedTime, DateTime selectedDate, string[] selectedAnimalSpecie, int selectCompanyCount)
        {
            //Gets all the animals from the database that has that specie name and puts them in the a list.
            List<Animal> animalsToAddToVisit = FindAllAnimalsFromDbByNames(selectedAnimalSpecie);
            var booking = _context.Visits.Include("Animals").Include("Visitor").FirstOrDefault(x => x.Id == visitId);

            if(booking != null)
            {
                booking.Animals = animalsToAddToVisit;
                booking.VisitTime = selectedTime;
                booking.DateToVisit = selectedDate;
                booking.CompanyCount = selectCompanyCount;

                _context.SaveChanges();
            }


            return RedirectToAction("BookAVisit", new {visitorId = booking.Visitor.ID });
        }
        public List<Animal> GetAvailableAnimals(string selectedTime, DateTime selectedDate)
        {
            List<string> animalSpecies = new List<string> { "Penguin", "Gargoyle", "Dragon", "Ant", "Hedgehog", "Snake", "Crab", "Cucumber", "Plankton" };
            List<Animal> availableAnimals = new List<Animal>();

            foreach (var animal in animalSpecies)
            {
                //Does the animal specie exist more than 2 times this day, gets the count
                var animalCount2 = _context.Visits.Include("Animals").Where(x => x.DateToVisit == selectedDate).Where(x => x.Animals.Any(a => a.SpecieName == animal)).Count();

                var individualAnimalCount = _context.Visits.Include("Animals").Where(x => x.DateToVisit == selectedDate).Where(t => t.VisitTime == selectedTime).Where(x => x.Animals.Any(a => a.SpecieName == animal)).Count();

                if (individualAnimalCount < 1)
                {
                    var addAnimal = _context.Animals.FirstOrDefault(x => x.SpecieName == animal);
                    availableAnimals.Add(addAnimal);
                }
            }

            return availableAnimals;
        }
        public List<Animal> FindAllAnimalsFromDbByNames(string[] selectedAnimalSpecies)
        {
            List<Animal> animals = new List<Animal> { };
            //var animals = _context.Animals.Where(x => selectedAnimalSpecie.Contains(x.ID)).ToList();
            foreach (var animal in selectedAnimalSpecies)
            {
                var animalsSelect = _context.Animals.Where(x => x.SpecieName == animal).ToList();
                foreach (var individualAnimal in animalsSelect)
                {
                    animals.Add(individualAnimal);
                }
            }
            return animals;
        }
    }
}