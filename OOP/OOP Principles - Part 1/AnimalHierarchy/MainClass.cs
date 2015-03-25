//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            Cat cat = new Cat(3, "Catty", 'F');
            Dog dog = new Dog(4, "Doggy", 'M');
            Frog frog = new Frog(80, "Froggy", 'F');
            Kitten kitten = new Kitten(2, "Kitty");
            Tomcat tomcat = new Tomcat(5, "Tom");

            List<Animal> animals = new List<Animal>()
            {
                cat, dog, frog, kitten, tomcat
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine(new string('-', 30));

            Cat[] cats = new Cat[] { new Cat(1, "Tommy", 'M'), new Cat(3, "Roshko", 'M'), new Cat(7, "Tita", 'F') };
            Dog[] dogs = new Dog[] { new Dog(4, "Ritta", 'F'), new Dog(2, "Mark", 'M'), new Dog(7, "Romeo", 'M') };
            Frog[] frogs = new Frog[] { new Frog(20, "Temenujka", 'F'), new Frog(63, "Durtofelnica", 'F'), new Frog(44, "Johny", 'M') };
            Kitten[] kittens = new Kitten[] { new Kitten(4, "Dinka"), new Kitten(1, "Pinka"), new Kitten(8, "Sinka") };
            Tomcat[] tomcats = new Tomcat[] { new Tomcat(5, "Leonardo"), new Tomcat(3, "Goshko"), new Tomcat(7, "Tiko") };

            Console.WriteLine("Average age of cats : " + Animal.AverageAge(cats));
            Console.WriteLine("Average age of dogs : " + Animal.AverageAge(dogs));
            Console.WriteLine("Average age of frogs : " + Animal.AverageAge(frogs));
            Console.WriteLine("Average age of kittens : " + Animal.AverageAge(kittens));
            Console.WriteLine("Average age of tomcats : " + Animal.AverageAge(tomcats));
        }
    }
}