using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal abstract class Animal
    {
        // Fields
        private string _name;
        private string _species;

        // Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name can't be null or white space.");
                _name = value;
            }
        }

        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Species can't be null or white space.");
                _species = value;
            }
        }

        // Abstract method with overriding so we can modify the iteration of code within.
        public abstract void MakeSound(); 
    }
}
