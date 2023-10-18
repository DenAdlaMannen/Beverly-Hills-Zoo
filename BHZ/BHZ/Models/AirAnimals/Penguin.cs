using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Penguin : Air
    {
        public string AnimalName { get; set; } = "Penguin";
        public string AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Endangered { get; set; }
        public override int MaxAltitude { get; set; }
    }
}
