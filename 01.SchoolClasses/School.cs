namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string nameOfSchool;

        public School(string nameOfSchool) 
        {
            this.NameOfSchool = nameOfSchool;
        }

        public string NameOfSchool
        {
            get 
            {
                return this.nameOfSchool;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.nameOfSchool = value;
            }
        }
    }
}
