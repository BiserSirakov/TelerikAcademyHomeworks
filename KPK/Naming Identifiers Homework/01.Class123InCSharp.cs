// Task 1. class_123 in C#
// Refactor the following examples to produce code with well-named C# identifiers.

namespace Naming_Identifiers_Homework
{
    using System;

    internal class Class123InCSharp
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            Converter converter = new Converter();
            converter.ConvertBooleanToString(true);
        }

        private class Converter
        {
            public void ConvertBooleanToString(bool boolean)
            {
                string booleanToString = boolean.ToString();
                Console.WriteLine(booleanToString);
            }
        }
    }
}
