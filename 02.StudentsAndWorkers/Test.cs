namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Test
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Angel", "Angelov", 4),
                new Student("Mariq", "Angelova", 6),
                new Student("Ivan", "Milev", 3),
                new Student("Milena", "Petrova", 5),
                new Student("Toni", "Andreev", 8),
                new Student("Vasil", "Vasilev", 2),
                new Student("Anna", "Ivanova", 9),
                new Student("Jordan", "Hristov", 12),
                new Student("Veselina", "Milenkova", 11),
                new Student("Stoqn", "Petrov", 10),
            };

            var workers = new List<Worker>
            {
                new Worker("Marin", "Marinov", 1000, 10),
                new Worker("Tihomir", "Stajkov", 940, 8),
                new Worker("Georgi", "Georgiev", 1900, 9),
                new Worker("Denica", "Hristova", 1000, 8),
                new Worker("Kristina", "Jordanova", 500, 5),
                new Worker("Anastasiq", "Dobreva", 350, 4),
                new Worker("Anton", "Minchev", 900, 8),
                new Worker("Iliq", "Branimirov", 800, 8),
                new Worker("Gabriela", "Gabrielova", 2000, 12),
                new Worker("Boris", "Georgiev", 500, 4)
            };
            
            Console.WriteLine("Students sorted by grade: ");
            SortByGrade(students);
            Console.WriteLine("Sorted by salary descending: ");
            SortBySalary(workers);

            var mergeStudentsAndWorkers = new List<Human>();
            mergeStudentsAndWorkers.AddRange(students);
            mergeStudentsAndWorkers.AddRange(workers);

            var personList = mergeStudentsAndWorkers.OrderBy(m => m.FirstName).ThenBy(m => m.LastName);

            Console.WriteLine("Students and workers merged and sorted by first and last name : \n");

            foreach (Human person in personList)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }

        public static void SortByGrade(this List<Student> students)
        {
            var sorted = students.OrderBy(x => x.Grade).ToList();;
            PrintInForStudents(sorted);
        }

        public static void SortBySalary(this List<Worker> workers)
        {
            var sortedDescending = workers.OrderByDescending(x => x.MoneyPerHour())
                .ToList();
            PrintInForWorkers(sortedDescending);
        }

        public static void PrintInForStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        public static void PrintInForWorkers(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();
        }
    }
}
