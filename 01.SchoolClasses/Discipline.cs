namespace _01.SchoolClasses
{
    using System;
    using System.Text;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string optionalComments;

        public Discipline(string name, int numberOfLectures, int exercisesCount)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = exercisesCount;
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
                    throw new ArgumentException("Lecture name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Lectures count cannot be less than 1!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Exercises count cannot be less than 1!");
                }

                this.numberOfExercises = value;
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

        public override string ToString()
        {
            return string.Format("\"{0}\"\nNumber of lectures: {1}\nNumber of exercises: {2}", this.Name,
                                 this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
