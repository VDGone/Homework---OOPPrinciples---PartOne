namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestAnimal
    {
        private static void AverageAge(IEnumerable<Animal> animals, IEnumerable<string> animalTypes)
        {
            foreach (var type in animalTypes)
            {
                double averageAge = (from animal in animals
                                     where Equals(animal.GetType().Name, type)
                                     select animal).Average(a => a.Age);

                Console.WriteLine("{0}: {1:F2} years", type, averageAge);
            }
        }

        static void Main(string[] args)
        {
            var animalTypes = new List<string> { "Cat", "Kitten", "Tomcat", "Dog", "Frog" };

            Kitten kotyo = new Kitten("Kotyo", 3);
            Tomcat silvestyr = new Tomcat("Silvestyr", 5);
            Frog barny = new Frog("Barny", 2, Animal.Gender.Male);
            Dog rex = new Dog("Rex", 7, Animal.Gender.Male);
            Cat Bud = new Cat("Bud", 5, Animal.Gender.Female);

            List<Animal> animals = new List<Animal>() { kotyo, silvestyr, barny, rex, Bud };
            
            Kitten[] kittens = new Kitten[] { kotyo, new Kitten("Fluffy", 1), new Kitten("Bet", 2) };
            Tomcat[] tomcats = new Tomcat[] { silvestyr, new Tomcat("Jack", 2), new Tomcat("Malcho", 1), new Tomcat("Pikachhu", 6) };
            Frog[] frogs = new Frog[] { barny, new Frog("Bobolina", 1, Animal.Gender.Female), new Frog("Burt", 2, Animal.Gender.Male) };
            Dog[] dogs = new Dog[] { rex, new Dog("Sharo", 3, Animal.Gender.Male), new Dog("Sancho", 10, Animal.Gender.Male) };
            Cat[] cats = new Cat[] { Bud };

            Console.WriteLine("Animals:\n");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
                Console.WriteLine();
            }

            Console.WriteLine("\nAnimals' average age:\n");
            AverageAge(animals, animalTypes);
            Console.WriteLine();
        }
    }
}
