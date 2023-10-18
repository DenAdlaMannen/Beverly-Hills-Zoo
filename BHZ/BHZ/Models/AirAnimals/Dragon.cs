using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Dragon : Air
    {
        public string Name { get; set; } = "Dragon";
        public string Description { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }    
        public bool Extinct { get; set; }
        
    }
}
