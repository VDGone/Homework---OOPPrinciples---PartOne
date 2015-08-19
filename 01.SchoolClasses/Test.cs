namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            School someSchool = new School("School");
            Console.WriteLine("School name: \"{0}\"\n", someSchool.NameOfSchool);

            var listOfStudents = new List<Student>()
            { 
                new Student ("Angel Geshev", "Class A"),
                new Student ("Deqn Balev", "Class A"),
                new Student ("Angel Marinov", "Class A"),
                new Student ("Boris Voinikov", "Class A"),
                new Student ("Galin Ivanov", "Class B"),
                new Student ("Zasmqn Zasmqnov", "Class B"),
                new Student ("Iglika Cvetanova", "Class B"),
                new Student ("Minka Breznikova", "Class B"),
                new Student ("Mariq Aleksandrova", "Class B")
            };

            Console.WriteLine("\nList of students:\n");

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student);
            }

            List<Student> studentsInClassA = new List<Student>();
            studentsInClassA.Add(listOfStudents[0]);
            studentsInClassA.Add(listOfStudents[1]);
            studentsInClassA.Add(listOfStudents[2]);
            studentsInClassA.Add(listOfStudents[3]);

            List<Student> studentsInClassB = new List<Student>();
            studentsInClassB.Add(listOfStudents[4]);
            studentsInClassB.Add(listOfStudents[5]);
            studentsInClassB.Add(listOfStudents[6]);
            studentsInClassB.Add(listOfStudents[7]);
            studentsInClassB.Add(listOfStudents[8]);

            Discipline math = new Discipline("Math", 10, 10);
            Discipline bulgarianLanguage = new Discipline("Bulgarian language", 20, 15);
            Discipline sport = new Discipline("Sport", 5, 5);
            Discipline physics = new Discipline("Physics", 5, 5);
            Discipline biology = new Discipline("Biology", 10, 10);

            Teacher mitkoKolev = new Teacher("Mitko Kolev");
            mitkoKolev.Disciplines.Add(math);
            mitkoKolev.Disciplines.Add(physics);

            Teacher elenaGeorgieva = new Teacher("Elena Georgieva");
            elenaGeorgieva.Disciplines.Add(bulgarianLanguage);

            Teacher stamatStamatov = new Teacher("Stamat Stamatov");
            stamatStamatov.Disciplines.Add(biology);
            stamatStamatov.Disciplines.Add(sport);

            List<Teacher> teachersForAClass = new List<Teacher>() { mitkoKolev, stamatStamatov };
            List<Teacher> teachersForBClass = new List<Teacher>() { elenaGeorgieva, mitkoKolev };

            Console.WriteLine("\nList of teachers:\n");

            foreach (Teacher teacher in teachersForAClass)
            {
                Console.WriteLine("{0} {1}", teacher.Name, string.Join("\n", teacher.Disciplines));
                Console.WriteLine();
            }

            Classes classA = new Classes("Class A", studentsInClassA);
            classA.Teachers = teachersForAClass;

            Classes classB = new Classes("Class B", studentsInClassB);
            classB.Teachers = teachersForBClass;

            Console.Write("\nClass: ");
            Console.WriteLine(classA);

            Console.Write("\nClass: ");
            Console.WriteLine(classB);

            classA.AddComment("Hi!");
            classA.AddComment("Bye!");

        }
    }
}
