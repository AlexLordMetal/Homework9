using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Rabbit : Herbivore, ICanWalk
    {

        public void Walk()
        {
            Console.WriteLine($"I'm rabbit {Name}, I'm walking");
        }

    }
}
