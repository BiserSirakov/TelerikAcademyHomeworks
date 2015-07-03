// Task 2. Make_Чуек in C#
// Refactor the following examples to produce code with well-named C# identifiers.

namespace Naming_Identifiers_Homework
{
    internal class MakeChuekInCSharp
    {
        private enum Gender 
        { 
            Male, 
            Female 
        }

        public void MakePerson(int age)
        {
            Person person = new Person();

            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Female;
            }
        }

        private class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
