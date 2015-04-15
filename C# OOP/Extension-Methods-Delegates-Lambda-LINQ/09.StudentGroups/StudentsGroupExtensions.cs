namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsGroupExtensions
    {
        public static List<Student> GroupTwo(this IList<Student> collection) // Problem 10
        {
            return collection.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName).ToList();
        }

        public static List<Student> HasTwoMarks(this IList<Student> collection) // Problem 14
        {
            return collection.Where(x => x.Marks.Count == 2).ToList();
        }
    }
}
