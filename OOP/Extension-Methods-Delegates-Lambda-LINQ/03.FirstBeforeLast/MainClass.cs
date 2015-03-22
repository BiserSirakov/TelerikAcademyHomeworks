namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            Student[] listOfStudents = new Student[6]
            {
                new Student("Arnold", "Schwarzenegger", 67),
                new Student("John", "Travolta", 61),
                new Student("Jim", "Carrey", 53),
                new Student("Jackie", "Chan", 60),
                new Student("Ninja", "Developer", 20),
                new Student("Gosho", "Peshov", 18)
            };

            foreach (Student student in listOfStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 30));

            Student[] newList = FirstBeforeLast(listOfStudents); // Problem 3

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            Student[] anotherList = AgeRange(listOfStudents); // Problem 4

            foreach (var item in anotherList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            listOfStudents = listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToArray(); // Problem 5

            foreach (var item in listOfStudents)
            {
                Console.WriteLine(item);
            }
        }

        private static Student[] FirstBeforeLast(Student[] arr)
        {
            return arr.Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToArray();
        }

        private static Student[] AgeRange(Student[] arr)
        {
            return arr.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();
        }
    }
}