namespace BHZ.Models.Habitats
{
    public abstract class Sea : Animal
    {
            public abstract int DivingDepth { get; set; }
            public string? SeaAnimalSpecie { get; set; }    
    }
}
