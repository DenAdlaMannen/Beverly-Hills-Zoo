using BHZ.Models.Habitats;

namespace BHZ.Models.AirAnimals
{
    public class Dragon : Air
    {
        public string AnimalName { get; set; } = "Dragon";
        public string AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }    
        public bool Extinct { get; set; }
        public override int MaxAltitude { get; set; }

        public Dragon(string animalName, string animalDescription, int weightMin, int weightMax, bool extinct, int MaxAltitude)
        {
            this.AnimalName = animalName;
            this.AnimalDescription = animalDescription;
            this.WeightMin = weightMin;
            this.WeightMax = weightMax;
            this.Extinct = extinct;
            this.MaxAltitude = MaxAltitude;
        }
    }
}
