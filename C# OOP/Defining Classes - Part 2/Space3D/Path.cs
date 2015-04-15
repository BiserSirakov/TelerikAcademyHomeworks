namespace Space3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private readonly List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D a)
        {
            this.points.Add(a);
        }

        public override string ToString()
        {
            return string.Join(", ", this.points);
        }
    }
}
