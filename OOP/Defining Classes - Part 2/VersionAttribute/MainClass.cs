namespace VersionAttribute
{
    using System;
    using System.Linq;
    using System.Reflection;

    class MainClass
    {
        [Version(VersionAttribute.Type.Class, "TestAttribute", "2.11")]
        static void Main()
        {
            var attr = typeof(MainClass).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in attr)
            {
                Console.WriteLine("{0}: {1}     Version: {2}",
                    attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}
