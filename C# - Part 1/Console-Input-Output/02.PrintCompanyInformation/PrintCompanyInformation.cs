﻿//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name : ");
        string companyName = Console.ReadLine();

        Console.Write("Company address : ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number : ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number : ");
        string faxNumber = Console.ReadLine();

        if (faxNumber.Length < 7)
        {
            faxNumber = "(no fax)";
        }

        Console.Write("Web site : ");
        string website = Console.ReadLine();

        Console.Write("Manager first name : ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name : ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age : ");
        string managerAge = Console.ReadLine();

        Console.Write("Manager phone : ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n" + companyName);
        Console.WriteLine("Address : " + companyAddress);
        Console.WriteLine("Tel: " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);

        Console.ReadLine();
    }
}
