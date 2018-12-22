using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Predator : Mammal, IEatAnimals
    {

        public void EatAnimal(Animal animal)
        {
            Console.WriteLine($"I'm predator {Name}, I have eaten {animal.Name}");
        }

    }
}
