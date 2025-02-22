using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public class ZooUtility
    {
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Animal Name: {name}");
        }

        public static void DescribeAnimal(string name, string species)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}");
        }

        public static void DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old");
        }
    }
}
