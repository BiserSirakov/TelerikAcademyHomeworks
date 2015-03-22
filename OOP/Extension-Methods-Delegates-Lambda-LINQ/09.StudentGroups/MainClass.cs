namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainClass
    {
        public static List<Student> listOfStudents = new List<Student>()
            {
                new Student("Albatros", "Kilimandjarov", 123310, "0888888888", "albatros@gmail.com", new List<double>() { 3, 4.5 }, 2),
                new Student("Beatris", "Katerichokov", 439906, "0888888881", "beatris@yahoo.com", new List<double>() { 5, 5.3, 5.9 }, 1),
                new Student("Boiko", "Borisov", 654506, "0888888882", "boiko@abv.bg", new List<double>() { 6, 2, 5.5 }, 2),
                new Student("Super", "Man", 885423, "02123321", "superman@abv.bg", new List<double>() { 5.9, 3, 4.5 }, 3)
            };

        public static void Main()
        {
            var newList = listOfStudents.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName).ToList(); // Problem 9

            foreach (Student student in newList)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            List<Student> listUsingExtension = listOfStudents.GroupTwo(); // Problem 10

            foreach (Student student in listUsingExtension)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            var validEmails = listOfStudents.Where(x => x.Email.Contains("abv.bg")); // Problem 11

            foreach (Student student in validEmails)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            var validPhone = listOfStudents.Where(x => x.Tel.StartsWith("02")); // Problem 12

            foreach (Student student in validPhone)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            var excellentMakrs = listOfStudents.Where(x => x.Marks.Contains(6)); // Problem 13

            foreach (Student student in excellentMakrs)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            foreach (Student student in listOfStudents.HasTwoMarks()) // Problem 14
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            var enrolled2006 = listOfStudents.Where(x => x.Fn.ToString()[4] == '0' && x.Fn.ToString()[5] == '6'); // Problem 15

            foreach (Student student in enrolled2006)
            {
                Console.WriteLine(string.Join(", ", student.Marks) + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            Group Mathematics = new Group(3, "Mathematics"); // Problem 16
            Group History = new Group(1, "History");
            Group Physics = new Group(2, "Physics");

            var listOfStudentsInMaths = listOfStudents.Where(x => x.GroupNumber == Mathematics.GroupNumber);

            foreach (Student student in listOfStudentsInMaths)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));
        }
    }
}