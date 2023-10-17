using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHZ
{
    public interface IMakeSound
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal doesn't have a sound.,");
        }
    }
}
