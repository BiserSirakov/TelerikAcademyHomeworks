namespace Space3D
{
    using System;

    public static class CalculateDistance
    {
        public static double Distance(Point3D a, Point3D b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
    }
}
