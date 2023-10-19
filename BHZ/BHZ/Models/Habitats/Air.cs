namespace BHZ.Models.Habitats
{
    public abstract class Air : Animal
    {
        public abstract int MaxAltitude { get; set; }
        public string? AirAnimalSpecie { get; set; }
    }
}
