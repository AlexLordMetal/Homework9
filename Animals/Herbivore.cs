using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Herbivore : Mammal, IEatGrass
    {

        public void EatGrass()
        {
            Console.WriteLine($"I'm herbivore {Name}, I have eaten grass");
        }

    }
}
