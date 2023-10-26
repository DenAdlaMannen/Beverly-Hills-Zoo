using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Penguin : Air, IMakeSound
    {
        public override int MaxAltitude { get; set; }

        public string MakeSound()
        {
            return "Sup?";
        }

        public override string move()
        {
            return "I fly";
        }
    }
}
