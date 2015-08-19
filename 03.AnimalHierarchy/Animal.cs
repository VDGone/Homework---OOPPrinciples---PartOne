namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        protected Animal(string name, int age, Gender sex)
        {
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
        }

        public Gender Sex { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You should enter name!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You should enter age!");
                }

                this.age = value;
            }
        }

        public enum Gender
        {
            Male,
            Female
        }

        public virtual string ProduceSound() 
        {
            return "Hi!";
        }

        public override string ToString()
        {
            return string.Format("Animal: {0}\nName: {1}\nGender: {2}\nAge: {3}\nsays: {4} ", this.GetType().Name, this.Name, this.Sex, this.Age, this.ProduceSound());
        }
    }
}
