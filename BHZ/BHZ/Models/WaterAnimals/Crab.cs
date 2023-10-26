using BHZ.Models.Habitats;

namespace BHZ.Models.WaterAnimals
{
    public class Crab : Sea
    {
        public override int DivingDepth { get; set; }

        public override string move()
        {
            return "I swim";
        }
    }
}
