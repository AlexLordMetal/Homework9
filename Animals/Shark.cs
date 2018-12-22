using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Shark : Fish, IEatAnimals
    {

        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"I'm shark {Name}, I have eating {animal.Name}");
        }

    }
}
