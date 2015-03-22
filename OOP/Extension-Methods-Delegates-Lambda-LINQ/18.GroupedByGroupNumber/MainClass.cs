namespace _18.GroupedByGroupNumber
{
    using System;
    using System.Linq;
    using _09.StudentGroups;

    class MainClass
    {
        static void Main()
        {
            var groupHistory = _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 1); // Problem 18
            var groupPhysics = _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 2);
            var groupMathematics = _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 3);

            Console.WriteLine("History group : ");
            foreach (Student student in groupHistory)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Physics group : ");
            foreach (Student student in groupPhysics)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Mathematics group : ");
            foreach (Student student in groupMathematics)
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            var groupedWithExtensionHistory = _09.StudentGroups.MainClass.listOfStudents.History(); // Problem 19
            var groupedWithExtensionPhysics = _09.StudentGroups.MainClass.listOfStudents.Physics();
            var groupedWithExtensionMathematics = _09.StudentGroups.MainClass.listOfStudents.Mathematics();
        }
    }
}
