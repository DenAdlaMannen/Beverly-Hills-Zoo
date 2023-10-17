using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHZ.Models.AirAnimals
{
    public class Flamingo : Air
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public override int MaxAltitude { get; set; }

        public Flamingo()
        {

        }

    }
}

