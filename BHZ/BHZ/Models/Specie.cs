using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHZ.Models
{
    public class Specie : Animal, IMakeSound
    {
        public string SpecieName { get; set; }
        public override void Move()
        {
            Console.WriteLine("");
        }
    }
}
