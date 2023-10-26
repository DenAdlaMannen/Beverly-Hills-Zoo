using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Dragon : Air, IMakeSound
    {
        public override int MaxAltitude { get; set; }

        public string MakeSound()
        {
            return "RAWWR!";
        }

        public override string move()
        {
            return "I fly";
        }
    }
}
