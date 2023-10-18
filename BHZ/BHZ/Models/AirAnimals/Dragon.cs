using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Dragon : Air
    {
        public string? AnimalName { get; set; }
        public string? AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
        public override int MaxAltitude { get; set; }

    }
}
