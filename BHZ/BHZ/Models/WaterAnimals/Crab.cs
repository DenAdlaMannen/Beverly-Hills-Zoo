using BHZ.Models.Habitats;

namespace BHZ.Models.WaterAnimals
{
    public class Crab : Water
    {
        public string Name { get; set; } = "Crab";
        public string Description { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
    }
}
