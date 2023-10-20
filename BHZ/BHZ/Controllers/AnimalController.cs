﻿using BHZ.Data;
using BHZ.Models;
using BHZ.Models.AirAnimals;
using BHZ.Models.LandAnimals;
using BHZ.Models.WaterAnimals;
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

            // Since the Animal class is abstract and cant be instanciated we dont know i


            switch (specieName)
            {
                case "Penguin": 
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
                        break;
                    }
                case "Gargoyle":
                    {
                        Animal newAnimal = new Gargoyle
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
                        break;
                    }
                case "Dragon":
                    {
                        Animal newAnimal = new Dragon
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
                        break;
                    }
                case "Ant":
                    {
                        Animal newAnimal = new Ant
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
                        break;
                    }
                case "Snake":
                    {
                        Animal newAnimal = new Snake
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
                        break;
                    }
                case "Hedgehog":
                    {
                        Animal newAnimal = new Hedgehog
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
                        break;
                    }
                case "Crab":
                    {
                        Animal newAnimal = new Crab
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
                        break;
                    }
                case "Cucumber":
                    {
                        Animal newAnimal = new Cucumber
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
                        break;
                    }
                case "Plankton":
                    {
                        Animal newAnimal = new Plankton
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
                        break;
                    }
                default: { break; }
            }

            ////Add Air animal
            //if (specieName == "Penguin" || specieName == "Dragon" || specieName == "Gargoyle")
            //{

            //    Animal newAnimal = new Penguin
            //    {
            //        SpecieName = specieName,
            //        Name = name,
            //        Description = description,
            //        Age = age,
            //    };

            //    // Lägg till den nya instansen i din DbContext
            //    _context.Animals.Add(newAnimal);

            //    // Spara ändringarna till databasen
            //    _context.SaveChanges();
            //}

            ////Add Land animal
            //if (specieName == "Ant" || specieName == "Snake" || specieName == "Hedgehog")
            //{

            //    Animal newAnimal = new Snake
            //    {
            //        SpecieName = specieName,
            //        Name = name,
            //        Description = description,
            //        Age = age,
            //    };

            //    // Lägg till den nya instansen i din DbContext
            //    _context.Animals.Add(newAnimal);

            //    // Spara ändringarna till databasen
            //    _context.SaveChanges();
            //}

            ////Add Water animal
            //if (specieName == "Crab" || specieName == "Penguin" || specieName == "Cucumber")
            //{

            //    Animal newAnimal = new Crab
            //    {
            //        SpecieName = specieName,
            //        Name = name,
            //        Description = description,
            //        Age = age,
            //    };

            //    // Lägg till den nya instansen i din DbContext
            //    _context.Animals.Add(newAnimal);

            //    // Spara ändringarna till databasen
            //    _context.SaveChanges();
            //}

            return RedirectToAction("AnimalView");
        }

        [HttpPost]
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
        public IActionResult UpdateAnimal()
        {
            return View();
        }
    }
}
