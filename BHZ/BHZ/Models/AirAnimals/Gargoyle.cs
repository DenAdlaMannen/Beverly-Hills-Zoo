using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Gargoyle : Air, IMakeSound
    {
        public override int MaxAltitude { get; set; }

        public string MakeSound()
        {
            return "I am pretty quiet...";
        }

        public override string move()
        {
            return "I fly";
        }
    }
}
