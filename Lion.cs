using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        public Lion(string nameLion, string speciesLion)
        {
            Name = nameLion;
            Species = speciesLion;
        }
        public override void MakeSound()
        {
            Console.Write("The lion roars!");
        }
    }
}
