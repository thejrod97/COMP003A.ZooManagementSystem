using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    class Parrot : Animal
    {
        public Parrot(string nameParrot, string speciesParrot)
        {
            Name = nameParrot;
            Species = speciesParrot;
        }
        public override void MakeSound()
        {
            Console.Write("The parrot squawks!");
        }        
    }
}
