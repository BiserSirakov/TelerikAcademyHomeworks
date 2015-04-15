//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, 
//specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace StudentClass
{
    using System;
    using Enumerations;

    class MainClass
    {
        static void Main()
        {
            Student student1 = new Student("Pesho", "Ivanov", "Goshov", 9201103315, "ul. Vishneva 2", "0898111888", "skeleta@abv.bg", 2, Speciality.Management, University.Oxford, Faculty.Economics);

            Student student2 = new Student("Pesho", "Ivanov", "Goshov", 9201103315, "ul. Vishneva 2", "0898111888", "skeleta@abv.bg", 2, Speciality.Management, University.Oxford, Faculty.Economics);

            Student student3 = new Student("Gosho", "Ivanov", "Peshov", 8812241152, "ul. Limonova 112", "0881555222", "ninjata@abv.bg", 1, Speciality.Philosophy, University.KingsCollege, Faculty.Phylosophy);

            Console.WriteLine("Student 1 : \n{0}\n", student1);
            Console.WriteLine("Student 2 : \n{0}\n", student2);
            Console.WriteLine("Student 3 : \n{0}\n", student3);

            Console.WriteLine("student1 and student2 are equal --> {0}", student1.Equals(student2));
            Console.WriteLine();
            Console.WriteLine("student2 and student3 are equal --> {0}", student2.Equals(student3));

            Console.WriteLine("\nstudent1`s hash code : {0}", student1.GetHashCode());
            Console.WriteLine("\nstudent2`s hash code : {0}", student2.GetHashCode());
            Console.WriteLine("\nstudent3`s hash code : {0}", student3.GetHashCode());

            Console.WriteLine("\nstudent1 == student2 --> {0}", student1 == student2);
            Console.WriteLine("student1 != student2 --> {0}", student1 != student2);

            var clonedStudent3 = student3.Clone();

            Console.WriteLine("\nCloned student3 : \n{0}", clonedStudent3);
        }
    }
}
