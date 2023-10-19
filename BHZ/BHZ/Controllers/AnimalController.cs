using BHZ.Data;
using BHZ.Models;
using BHZ.Models.AirAnimals;
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
        public IActionResult AddAnimal()
        {
            var animals = _context.Animals.ToList();
            return View(animals);
        }
        [HttpPost]
        public IActionResult AddAnimalAction(string specieSelect, string animalName, string animalStory, int animalAge)
        {
            // Skapa en ny instans av Animal med de inskickade värdena

            //Add Air animal


            //Add Land animal

            //Add Water animal
            if (specieSelect == "Crab" || specieSelect == "Penguin" || specieSelect == "Cucumber")
            {

                Animal newAnimal = new Penguin
                {
                    SpecieName = specieSelect,
                    Name = animalName,
                    Description = animalStory,
                    Age = animalAge,
                };

                // Lägg till den nya instansen i din DbContext
                _context.Animals.Add(newAnimal);

                // Spara ändringarna till databasen
                _context.SaveChanges();
            }





            // Om du vill, kan du returnera något, till exempel en vy eller en redirect
            return RedirectToAction("AnimalView");
        }

        public IActionResult DeleteAnimal()
        {
            return View();
        }
    }
}
