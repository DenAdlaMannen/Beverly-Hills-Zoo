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
        public IActionResult AddAnimalAction(string specieName, string name, string description, int age)
        {
            // Skapa en ny instans av Animal med de inskickade värdena

            //Add Air animal


            //Add Land animal

            //Add Water animal
            if (specieName == "Crab" || specieName == "Penguin" || specieName == "Cucumber")
            {

                Animal newAnimal = new Penguin
                {
                    SpecieName = specieName,
                    Name = name,
                    Description = description,
                    Age = age,
                };

                // Lägg till den nya instansen i din DbContext
                _context.Animals.Add(newAnimal);

                // Spara ändringarna till databasen
                _context.SaveChanges();
            }





            // Om du vill, kan du returnera något, till exempel en vy eller en redirect
            return RedirectToAction("AnimalView");
        }
        [HttpPost]
        public IActionResult DeleteAnimal(int animalID)
        {
			// Find the animal in the database using the provided ID
			var animal = _context.Animals.Find(animalID);

			// If the animal exists, remove it
			if (animal != null)
			{
				_context.Animals.Remove(animal);
				_context.SaveChanges();
			}

			// Redirect back to the AnimalView
			return RedirectToAction("AnimalView");
		}
    }
}
