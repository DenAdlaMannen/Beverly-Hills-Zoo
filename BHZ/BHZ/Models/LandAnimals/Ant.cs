using BHZ.Models.Habitats;

namespace BHZ.Models.LandAnimals
{
    public class Ant : Land, IMakeSound
    {
        public override int Speed { get; set; }

        public string MakeSound()
        {
            return "Im a fast ant";
        }

        public override string move()
        {
            return "I run";
        }
    }
}
