using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Bird : Animal, ICanFly
    {

        public void Fly()
        {
            Console.WriteLine($"I'm bird {Name}, I'm flying");
        }

    }
}
