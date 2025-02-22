// Author: Justin Rodriguez 
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#.
namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("\nWelcome to the Zoo Management System!");

                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                Console.Write("\nYour choice: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    try
                    {
                        Console.Write("Enter the name of the lion: ");
                        string nameLion = Console.ReadLine();
                        if (string.IsNullOrEmpty(nameLion))
                        {
                            throw new ArgumentException("Name can't be empty.");
                        }

                        Console.Write("Enter the species of the lion: ");
                        string speciesLion = Console.ReadLine();
                        if (string.IsNullOrEmpty(speciesLion))
                        {
                            throw new ArgumentException("Species can't be empty.");
                        }

                        Lion lion = new Lion(nameLion, speciesLion);
                        animals.Add(lion); // added to collection

                        Console.WriteLine("\nLion added successfully!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Error: Name cannot be empty. Please provide a valid name.");
                    }
                   
                }
                else if (input == 2)
                {
                    try
                    {
                        Console.Write("Enter the name of the parrot: ");
                        string nameParrot = Console.ReadLine();
                        if (string.IsNullOrEmpty(nameParrot))
                        {
                            throw new ArgumentException("Name can't be empty.");
                        }

                        Console.Write("Enter the species of the parrot: ");
                        string speciesParrot = Console.ReadLine();
                        if (string.IsNullOrEmpty(speciesParrot))
                        {
                            throw new ArgumentException("Species can't be empty.");
                        }

                        Parrot parrot = new Parrot(nameParrot, speciesParrot);
                        animals.Add(parrot); // added to collection

                        Console.WriteLine("\nParrot added successfully!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Error: Name cannot be empty. Please provide a valid name.");
                    }
                    
                }
                else if (input == 3)
                {
                    Console.WriteLine("Displaying all animals:");
                    foreach (Animal animal in animals)
                    {
                        if (animal is Lion lion)
                        {
                            lion.MakeSound();
                            Console.WriteLine($" ({lion.Name}, {lion.Species})");
                        }
                        else if (animal is Parrot parrot)
                        {
                            parrot.MakeSound();
                            Console.WriteLine($" ({parrot.Name}, {parrot.Species})");
                        }
                    }
                }
                else if (input == 4)
                {
                    Console.WriteLine("DescribeAnimal (name only):");
                    ZooUtility.DescribeAnimal("Simba");

                    Console.WriteLine("\nDescribeAnimal (name and species):");
                    ZooUtility.DescribeAnimal("Polly","Psittaciformes");

                    Console.WriteLine("\nDescribeAnimal (name, species, and age):");
                    ZooUtility.DescribeAnimal("Charlie", "Elephant", 12);
                }
                else
                {
                    Console.WriteLine("\nHave a nice day!");
                    break;
                }
            }
        }
    }
}
