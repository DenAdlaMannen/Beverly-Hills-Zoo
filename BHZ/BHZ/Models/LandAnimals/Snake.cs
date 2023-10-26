using BHZ.Models.Habitats;

namespace BHZ.Models.LandAnimals
{
    public class Snake : Land, IMakeSound
    {
        public override int Speed { get; set; }

        public string MakeSound()
        {
            return "Pssssss....";
        }

        public override string move()
        {
            return "I run";
        }
    }
}
