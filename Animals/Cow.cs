using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow: Herbivore, ICanWalk
    {

        public void Walk()
        {
            Console.WriteLine($"I'm cow {Name}, I'm walking");
        }

    }
}
