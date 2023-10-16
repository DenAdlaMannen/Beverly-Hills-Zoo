using BHZ.Models;

namespace BHZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualAnimal individualAnimal = new IndividualAnimal();

            individualAnimal.Age = 10;
            individualAnimal.Weight = 11;
            individualAnimal.Name = "Olle";
            individualAnimal.SpecieName = "Gorilla";

            individualAnimal.MakeSound();
        }
    }
}