using System.ComponentModel.DataAnnotations;

namespace BHZ.Models
{
    public abstract class Animal
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string SpecieName { get; set; }
        public string? SpecieDescription { get; set; }
        public int SpecieWeightMin { get; set; }
        public int SpecieWeightMax { get; set; }
        public bool Endangered { get; set; }
        public string? HabitatType { get; set; }
    }
}
