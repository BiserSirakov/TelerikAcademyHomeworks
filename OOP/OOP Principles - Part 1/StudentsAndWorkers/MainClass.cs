//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money 
//earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            Worker doncho = new Worker("Doncho", "Minkov", 400, 8);

            Console.WriteLine(doncho);

            Console.WriteLine("Money per hour : " + doncho.MoneyPerHour());

            Console.WriteLine(new string('-', 30));

            List<Student> students = new List<Student>() 
            {
                new Student("Pesho", "Goshov", 2.0),
                new Student("Gosho", "Peshkiev", 3.5),
                new Student("Atanaska", "Atanaskova", 4.1),
                new Student("Shkaf", "Shkafov", 2.0),
                new Student("Surbin", "Surbinov", 3.1),
                new Student("Toshko", "Todorov", 6.0),
                new Student("Ivancho", "Mariikov", 5.4),
                new Student("Mariika", "Ivanchova", 5.8),
                new Student("Petyo", "Petkanov", 4.9),
                new Student("Alfred", "Tikov", 3.2),
            };

            var orderedStudents = students.OrderBy(x => x.Grade);

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 30));

            List<Worker> workers = new List<Worker>() 
            {
                new Worker("Pesho", "Goshov", 500, 9),
                new Worker("Gosho", "Peshkiev", 150, 12),
                new Worker("Atanaska", "Atanaskova", 700, 6),
                new Worker("Shkaf", "Shkafov", 1000, 4),
                new Worker("Surbin", "Surbinov", 100, 5),
                new Worker("Toshko", "Todorov", 5443, 10),
                new Worker("Ivancho", "Mariikov", 988, 9),
                new Worker("Mariika", "Ivanchova", 851, 6),
                new Worker("Petyo", "Petkanov", 1000, 10),
                new Worker("Alfred", "Tikov", 450, 10),
            };

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            foreach (Worker worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new string('-', 30));

            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            var orderedMergedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (Human human in orderedMergedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}