using System;

class Employee
{
    static void Main()
    {
        string firstName = "Biser";
        string lastName = "Sirakov";
        byte age = 20;
        char gender = 'M';
        long id = 8306112507;
        ulong employeenum = 275600027569999;

        Console.WriteLine("First name : {0}", firstName);
        Console.WriteLine("Last name : {0}", lastName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("Personal ID number : {0}", id);
        Console.WriteLine("Unique employee number : {0}", employeenum);

        Console.ReadLine();
    }
}
