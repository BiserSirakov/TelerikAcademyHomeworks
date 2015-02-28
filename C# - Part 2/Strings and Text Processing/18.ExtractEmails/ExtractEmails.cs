//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Linq;
using System.Net.Mail;
using System.Text;

class ExtractEmails
{
    static char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };
    static char[] trimmers = new char[] { '.', '-', '/', '\\' };

    static void Main()
    {
        string text = "Hi! My email @ yahoo is myemail@yahoo.com. I also have 101mailGO@mail_provider.co.uk! You can write me to my work-email too:work_mail@privider.at.my.work";
        
        string[] input = text
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
             .Where(x => EmailIsValid(x.Trim(trimmers)))
             .ToArray();

        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine(GetEMails(input));
    }

    private static string GetEMails(string[] input)
    {
        StringBuilder result = new StringBuilder();

        foreach (var email in input)
        {
            result.AppendLine(email.Trim(trimmers));
        }


        if (result.Length == 0)
            result.AppendLine("No emails found!");
        return result.ToString();
    }

    static bool EmailIsValid(string email)
    {
        try
        {
            MailAddress address = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}