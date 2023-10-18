using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Penguin : Air
    {
        public string Name { get; set; } = "Penguin";
        public string Description { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Endangered { get; set; }
    }
}
