namespace Space3D
{
    using System;

    class MainClass
    {
        static void Main()
        {
            Point3D point1 = new Point3D(0, 1.6, 2); // Problem 1
            Console.WriteLine("Point 1 : {0}", point1);
            Point3D point2 = new Point3D(3, 1, 8.4);
            Console.WriteLine("Point 2 : {0}", point2);

            Point3D pointO = Point3D.StartPoint; // Problem 2
            Console.WriteLine("Point O : {0}", pointO);

            double distance = CalculateDistance.Distance(point1, point2); // Problem 3
            Console.WriteLine("Distance : {0:F2}", distance);

            Path path = new Path(); // Problem 4
            path.AddPoint(point1);
            path.AddPoint(point2);
            path.AddPoint(pointO);

            Console.WriteLine("Path : {0}", path);

            PathStorage.Save(path);

            Path newPath = PathStorage.Load();


        }
    }
}
