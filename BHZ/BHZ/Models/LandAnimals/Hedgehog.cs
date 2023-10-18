using BHZ.Models.Habitats;

namespace BHZ.Models.LandAnimals
{
    public class Hedgehog : Land
    {
        public string AnimalName { get; set; } = "Hedgehog";
        public string AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
        public override int Speed { get; set; }
    }
}
