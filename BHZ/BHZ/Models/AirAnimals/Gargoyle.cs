using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Gargoyle : Air
    {
        public string AnimalName { get; set; } = "Gargoyle";
        public string AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
        public override int MaxAltitude { get; set; }
    }
}
