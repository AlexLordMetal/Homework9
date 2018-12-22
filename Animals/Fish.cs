using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fish : Animal, ICanSwim
    {

        public void Swim()
        {
            Console.WriteLine($"I'm bird {Name}, I'm swimming");
        }

    }
}
