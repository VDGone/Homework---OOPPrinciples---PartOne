namespace _01.SchoolClasses
{
    using System;
    using System.Text;

    public class Person : IComment
    {
        private string name;
        private string optionalComments;

        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }

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
                    throw new ArgumentNullException("You may enter first and last name!");
                }
                this.name = value;
            }
        }

        public string OptionalComments
        {
            get { return this.optionalComments; }
        }

        public void AddComment(string input)
        {
            StringBuilder currentList = new StringBuilder(this.optionalComments);
            currentList.AppendLine(input);
            this.optionalComments = currentList.ToString();
        }
    }
}
