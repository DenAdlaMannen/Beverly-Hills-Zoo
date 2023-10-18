using System.ComponentModel.DataAnnotations;

namespace BHZ.Models
{
    public abstract class Animal
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int age { get; set; }
    }
}
