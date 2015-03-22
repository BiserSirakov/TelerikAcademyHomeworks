namespace _18.GroupedByGroupNumber
{
    using System.Linq;
    using _09.StudentGroups;
    using System.Collections.Generic;

    public static class GroupedExtension // Problem 19
    {
        public static List<Student> History(this IList<Student> collection)
        {
            return _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 1).ToList();
        }

        public static List<Student> Physics(this IList<Student> collection)
        {
            return _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 2).ToList();
        }

        public static List<Student> Mathematics(this IList<Student> collection)
        {
            return _09.StudentGroups.MainClass.listOfStudents.Where(x => x.GroupNumber == 3).ToList();
        }
    }
}
