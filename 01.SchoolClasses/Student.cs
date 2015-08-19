namespace _01.SchoolClasses
{
    using System;

    public class Student : Person
    {
        private string classID;

        public Student(string name)
            : base(name)
        {
        }

        public Student(string name, string classID)
            : this(name)
        {
            this.ClassID = classID;
        }

        public string ClassID
        {
            get
            {
                return this.classID;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You should enter ClassID");
                }

                this.classID = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Class ID: {1}\n *{2}*", this.Name, this.ClassID, this.OptionalComments);
        }
    }
}
