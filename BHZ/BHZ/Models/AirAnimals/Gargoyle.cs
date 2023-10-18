using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Gargoyle : Air
    {
        public string Name { get; set; } = "Gargoyle";
        public string Description { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
    }
}
