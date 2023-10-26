namespace BHZ.Models.Habitats
{
    public abstract class Land : Animal
    {
        public abstract int Speed { get; set; }
        public string? LandAnimalSpecie { get; set; }

    }
}
