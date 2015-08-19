namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, byte age, Animal.Gender sex)
            : base(name, age, sex)
        {
        }

        public override string ProduceSound()
        {
            return "Kwa - kwa";
        }
    }
}
