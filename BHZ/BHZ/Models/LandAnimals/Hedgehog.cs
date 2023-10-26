using BHZ.Models.Habitats;

namespace BHZ.Models.LandAnimals
{
    public class Hedgehog : Land, IMakeSound
    {
        public override int Speed { get; set; }

        public string MakeSound()
        {
            return "Yo.";
        }

        public override string move()
        {
            return "I run";
        }
    }
}
