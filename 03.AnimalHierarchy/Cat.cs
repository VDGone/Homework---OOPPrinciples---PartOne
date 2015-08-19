namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Animal.Gender sex)
            : base(name, age, sex)
        {
        }

        public override string ProduceSound()
        {
            return "Miao - miaoooooo!";
        }
    }
}
