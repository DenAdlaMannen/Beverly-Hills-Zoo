using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHZ.Models
{
    public class Water : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I swim");
        }
    }
}
