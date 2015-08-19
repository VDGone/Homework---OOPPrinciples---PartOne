namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Classes : IComment
    {
        private string classID;
        private IList<Student> students;
        private IList<Teacher> teachers;
        private string optionalComments;

        public Classes(string classID)
        {
            this.ClassID = classID;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            this.optionalComments = string.Empty;
        }

        public Classes(string classID, IList<Student> students)
            : this(classID)
        {
            this.Students = students;
        }

        public Classes(string classId, IList<Teacher> teachers)
            : this(classId)
        {
            this.Teachers = teachers;
        }

        public string ClassID
        {
            get
            {
                return this.classID;
            }

            private set
            {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Class ID must not be null or empty");
                    }

                    this.classID = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value.Count < 1 || value.Count > 30)
                {
                    throw new ArgumentException("Class must be 1 - 30 students!");
                }

                this.students = value;
                foreach (Student student in value)
                {
                    if (string.IsNullOrEmpty(student.ClassID))
                    {
                        student.ClassID = this.ClassID;
                    }
                }
            }
        }

        public IList<Teacher> Teachers
        {
            get 
            { 
                return this.teachers; 
            }
            set 
            { 
                this.teachers = value; 
            }
        }

        public string OptionalComments
        {
            get 
            { 
                return this.optionalComments; 
            }
        }

        public void AddComment(string input)
        {
            StringBuilder currentList = new StringBuilder(this.OptionalComments);
            currentList.AppendLine(input);
            this.optionalComments = currentList.ToString();
        }

        public override string ToString()
        {
            return string.Format("\"{0}\"\n*{1}*\n\nTeachers:\n{2}\n\nStudents:\n{3}", this.ClassID,
                                 this.OptionalComments, string.Join("\n", this.teachers), string.Join("\n", this.students));
        }
    }
}
