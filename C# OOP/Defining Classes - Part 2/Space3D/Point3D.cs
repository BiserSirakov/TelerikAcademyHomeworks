namespace Space3D
{
    using System;

    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startPoint = new Point3D(0, 0, 0); // Problem 2

        public Point3D(double x, double y, double z) // Problem 1
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public override string ToString() // Problem 1
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
