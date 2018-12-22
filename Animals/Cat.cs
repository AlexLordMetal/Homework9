using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Predator, ICanWalk
    {

        public void Walk()
        {
            Console.WriteLine($"I'm cat {Name}, I'm walking");
        }

        public new void EatAnimal(Animal animal)
        {
            if (animal is Fish)
            {
                Console.WriteLine($"I'm cat {Name}, I have eaten {animal.Name}");
            }
            else
            {
                Console.WriteLine($"I'm cat {Name}, but I don't want to eat {animal.Name}, I want to eat a fish");
            }
        }

    }
}