namespace Space3D
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        private static readonly string filePath = @"..\..\SavedPaths.txt";

        public static void Save(Path path)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(path);
            }
        }

        public static Path Load()
        {
            Path path = new Path();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                double[] coordinates = reader.ReadToEnd()
                    .Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => double.Parse(x))
                    .ToArray();

                for (int a = 0, b=1, c=2; a < coordinates.Length && b < coordinates.Length && c < coordinates.Length; a+=3, b+=3, c+=3)
                {
                    path.AddPoint(new Point3D(coordinates[a], coordinates[b], coordinates[c]));
                }
            }

            return path;
        }
    }
}
