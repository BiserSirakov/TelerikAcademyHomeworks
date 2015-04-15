//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace PersonClass
{
    using System;

    class MainClass
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 25);
            Person gosho = new Person("Gosho");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
